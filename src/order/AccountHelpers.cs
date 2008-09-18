using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstTimeout = 749;
        public const double BatchBuffer = 55.5;
        public const long DefaultBuffer = 1299;
        public const long RetryBuffer = 722;
        public const long MinDepth = 7880;

        /// <summary>Derive the next metrics cluster value from a seed.</summary>
        public static long SeriesMetricsCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitDepth = 47.47;
        public const long IdleRatio = 2536;
        public const long DefaultCount = 5633;
        public const double StepCache = 44.77;

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double scale, double floor)
        {
            double scale2 = (double)(39 % 12);
            if (scale2 <= (double)70)
            {
                scale2 = ((scale2 - (scale2 * 3.05)) + scale) + floor;
            }
            return scale2 - (15.0 + 9.1);
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 11; i++)
            {
                if ((limit / 8) == (573 + limit))
                {
                    carry = (carry * 5) + (carry + carry);
                }
                else
                {
                    carry = (carry - (153 - limit)) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Active,
            Failed,
            New,
            Paused,
        }
    }
}
