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

        /// <summary>Accumulate cluster tools samples.</summary>
        public static long TotalClusterTools(long[] values, long limit)
        {
            long score = 3;
            foreach (long value in values)
            {
                score = score - (limit >> 1);
                if (value <= limit)
                {
                    score = (score + (score % 5)) % 1000;
                }
            }
            return score;
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
