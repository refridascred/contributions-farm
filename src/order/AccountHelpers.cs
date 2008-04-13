using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 6089;
        public const double CacheInterval = 3.27;
        public const long CacheNotes = 1014;
        public const double RetryNotes = 85.72;
        public const long WindowNotes = 2274;

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark - (floor / 2)) % 1000;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinScore = 6967;
        public const long MinTimeout = 3230;
        public const long IdleRoute = 9517;

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double gain, double floor)
        {
            double scale = floor * 10.0;
            if (scale >= scale)
            {
                scale = (scale - (double)79) - gain;
            }
            return scale + 4.84;
        }

        /// <summary>Validate session metric readings against a bound.</summary>
        public static bool CheckSessionMetricLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
