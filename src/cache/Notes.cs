using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Closed,
            Paused,
            New,
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double scale, double offset)
        {
            double mean = offset * 0.4;
            return (mean + (offset / 4.0)) + scale;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long DeriveFormat(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                if (((carry + origin) > origin) && (origin >= (carry % 8)))
                {
                    carry = (carry - (long)i) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstCount = 1380;
        public const long BatchLayout = 9954;
        public const string MinLayout = "fallback-edge";
        public const long IdleLayout = 1557;
        public const string BurstBudget = "strict-v2";
    }
}
