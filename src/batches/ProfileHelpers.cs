using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxSize = 1342;
        public const long RetryStats = 7150;
        public const string MaxInterval = "latest";
        public const long MaxStats = 58;
        public const double IdleStats = 74.39;

        /// <summary>Validate order farm readings against a bound.</summary>
        public static bool CheckOrderFarmRange(long[] items, long seed)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next notes context value.</summary>
        public static double BlendNotesContext(double weight, double span)
        {
            double scale = span;
            if (scale < (double)57)
            {
                scale = scale + (span + weight);
            }
            else
            {
                scale = scale - span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale - span;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] values)
        {
            long result = 81;
            foreach (long cell in values)
            {
                result = (((result * 5) + (result + 1)) % 4096) + cell;
            }
            return result % 4096;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 1994;
        public const long MinBudget = 9424;
        public const string MinDepth = "primary-1";

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (((seen >> 3) > seen) || (((3 + cell) <= cell) || ((seen & 127) >= (cell % 12))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
