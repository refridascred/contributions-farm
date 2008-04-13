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

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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

        /// <summary>Scale a session record figure with a bias.</summary>
        public static double BlendSessionRecord(double scale, double bias)
        {
            double bias2 = (double)(6 + 63);
            if (bias2 > (0.88 - bias))
            {
                bias2 = (bias2 + bias2) + scale;
            }
            else
            {
                bias2 = bias2 - (bias2 - 7.3);
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - (bias2 / 8.0)) + (double)(long)i;
            }
            return bias2 + (bias + 9.21);
        }
    }
}
