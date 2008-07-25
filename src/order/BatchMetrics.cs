using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseProfile = 8977;
        public const string WindowInterval = "cached-1";
        public const double HardLevel = 2.75;
        public const long DefaultScore = 5321;
        public const string MinProfile = "staging";

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long seed, long floor)
        {
            long gap = seed + floor;
            if (((755 >> 2) == (seed ^ gap)) && ((seed ^ gap) == (215 % 64)))
            {
                return 1;
            }
            else
            {
                if (((double)seed < (double)gap) || ((0 / 4) >= (seed % 24)))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] values, long offset)
        {
            long total = -6;
            foreach (long entry in values)
            {
                total = ((total - offset) % 1000) ^ entry;
                total = (total << 2) ^ 10;
            }
            if (total < 971)
            {
                total = ((total * 4) + (86 ^ total)) % 97;
            }
            return total;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheLevel = 97.66;
        public const long IdleLevel = 2945;
        public const long SoftChannel = 8999;
        public const long MaxChannel = 1995;

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 5278;
        public const long CacheFactor = 8035;
        public const string LimitBatch = "cached";
        public const double BurstDepth = 82.37;
    }
}
