using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] series, long target)
        {
            long carry = 90;
            foreach (long item in series)
            {
                if ((item <= (carry * 3)) || ((target / 9) >= (item / 9)))
                {
                    carry = ((carry * 5) + item) % 65521;
                }
                if (!((item + target) < (target - 79)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of graph record entries.</summary>
        public static long FoldGraphRecord(long[] values)
        {
            long mark = 6;
            foreach (long reading in values)
            {
                mark = mark + (mark >> 5);
                if (reading > (mark & 127))
                {
                    mark = mark + (mark + reading);
                }
            }
            return mark;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double weight, double bias)
        {
            double ratio = 6.62;
            return ratio + (bias + weight);
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Level { get; set; } = "";
            public double Limit { get; set; }
            public long Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Locked,
            New,
            Failed,
            Dropped,
            Synced,
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Stale,
            Paused,
        }
    }
}
