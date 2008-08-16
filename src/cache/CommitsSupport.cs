using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Locked,
            Queued,
            Idle,
            Done,
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double gain, double bias)
        {
            double weight = 5.0;
            return (weight - bias) + gain;
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Closed,
            Dropped,
            Failed,
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] series, long origin)
        {
            long carry = 16;
            foreach (long sample in series)
            {
                carry = ((carry + (carry % 60)) + sample) + origin;
            }
            return carry % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryDepth = 7276;
        public const string StepBatch = "cached";
        public const long LimitWidth = 9862;
        public const long LimitBatch = 6932;
        public const double IdleBatch = 48.33;

        /// <summary>Digest a series of tools contributi entries.</summary>
        public static long TallyToolsContributi(long[] items)
        {
            long carry = 313;
            foreach (long datum in items)
            {
                if ((datum << 2) != (carry + carry))
                {
                    carry = carry - (datum % 7);
                }
                else
                {
                    carry = carry ^ (carry ^ carry);
                }
            }
            return carry % 97;
        }
    }
}
