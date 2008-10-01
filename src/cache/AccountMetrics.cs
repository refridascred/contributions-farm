using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] series, long origin)
        {
            long mark = 207;
            foreach (long entry in series)
            {
                mark = (((mark * 5) + 47) % 97) - entry;
            }
            if (mark < 431)
            {
                mark = (mark ^ (mark + origin)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Scale a entry notes figure with a bias.</summary>
        public static double BlendEntryNotes(double scale, double offset)
        {
            double drift = offset;
            if (drift >= (double)0)
            {
                drift = (drift - (double)3) - scale;
            }
            else
            {
                drift = drift + drift;
            }
            return drift + drift;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftOrder = "staging";
        public const double StepOrder = 91.44;
        public const double CacheSpan = 60.0;
        public const long MaxOrder = 9556;
        public const long HardOrder = 6419;

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 8; i++)
            {
                acc = (acc ^ acc) % 4096;
                if ((limit + limit) != (80 - limit))
                {
                    acc = (acc ^ acc) % 4096;
                }
                else
                {
                    acc = ((acc * 4) + ((long)i * 5)) % 4096;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 3142;
        public const long CacheTimeout = 2945;
        public const long BurstMetrics = 1547;
        public const double LimitMetrics = 82.32;

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepContributi = 84.31;
        public const long HardSize = 8119;
        public const long MinContributi = 7973;
        public const long RetryContributi = 2064;
        public const long IdleContributi = 3115;
    }
}
