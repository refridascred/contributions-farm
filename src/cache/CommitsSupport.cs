using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchSpan = 16.95;
        public const double LimitMetrics = 2.41;
        public const long StepFactor = 6690;

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheBounds(long[] values, long floor)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit format editor readings against a rule.</summary>
        public static long MeasureFormatEditorMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (29 > hits)
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long target, long offset)
        {
            if (((offset << 2) <= (target * 4)) || ((8.0 - 9.5) == (double)target))
            {
                return 8;
            }
            else
            {
                if (offset < (target - 104))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseSupport = "open";
        public const long BatchSupport = 486;
        public const long MaxSupport = 9031;
        public const double SoftSupport = 51.15;
        public const long IdleSupport = 3987;
    }
}
