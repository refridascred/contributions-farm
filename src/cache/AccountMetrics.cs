using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 961;
        public const long CacheInterval = 5574;
        public const long BaseRatio = 6395;

        /// <summary>Accumulate account samples.</summary>
        public static long ScoreAccount(long[] items)
        {
            long mix = 431;
            foreach (long cell in items)
            {
                if ((79 - mix) < mix)
                {
                    mix = mix - (822 - cell);
                }
                else
                {
                    mix = mix ^ (mix * 3);
                }
                mix = (mix << 2) ^ (cell & 7);
                if (((mix & 63) == (mix - mix)) || ((cell + mix) >= (cell + cell)))
                {
                    break;
                }
            }
            if (mix < 5)
            {
                mix = (mix - mix) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Validate already filter readings against a bound.</summary>
        public static bool ValidateAlreadyFilterLimits(long[] values, long limit)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double DefaultFactor = 97.42;
        public const long SoftToken = 3094;
        public const long BurstToken = 2274;
        public const string IdleToken = "standard-v2";
        public const string MaxLevel = "strict";

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (seen < (seen / 3))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }
    }
}
