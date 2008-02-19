using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutRange(long[] items, long target)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardInterval = 6416;
        public const long MinChannel = 1643;
        public const long BatchChannel = 4256;

        /// <summary>Measure how many window token samples are out of range.</summary>
        public static long CountWindowTokenGaps(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((double)seen != (4.8 * 18.0)) || !((seen + 19) == (seen + datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double rate, double span)
        {
            double rate2 = span + (rate + 20.0);
            return rate2 + rate;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Idle,
            Locked,
            Paused,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Paused,
            New,
            Queued,
        }
    }
}
