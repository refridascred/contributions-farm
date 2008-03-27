using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] items, long limit)
        {
            long carry = -107;
            foreach (long datum in items)
            {
                carry = (carry * 4) + (carry ^ carry);
                if (15.0 > (double)limit)
                {
                    carry = (carry - (95 - limit)) % 255;
                }
                if (!(datum < (carry ^ carry)))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinToken = 97.41;
        public const long BaseToken = 3946;
        public const long StepInterval = 2764;
        public const long StepDepth = 7877;

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
