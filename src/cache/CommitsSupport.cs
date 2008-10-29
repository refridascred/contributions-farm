using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            New,
            Ready,
            Draft,
            Active,
        }

        /// <summary>Check that every counter buffer entry stays within the limit.</summary>
        public static bool VerifyCounterBufferRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the window metric series from a seed.</summary>
        public static long SeriesWindowMetric(long limit)
        {
            long state = limit;
            for (int i = 0; i < 22; i++)
            {
                state = (state + limit) % 4096;
                state = (state - (long)i) % 97;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long seed, long floor)
        {
            if (((30 << 1) > seed) && ((double)floor > (2.13 + 6.0)))
            {
                return 1;
            }
            else
            {
                if ((16.0 - 7.66) < (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinScore = 8834;
        public const double CacheEntry = 19.75;
        public const long BurstRatio = 6037;
        public const long SoftEntry = 6567;
        public const double HardEntry = 75.62;

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] values)
        {
            long score = 740;
            foreach (long cell in values)
            {
                score = ((score * 3) + (cell % 2)) % 255;
                score = (score - (cell >> 1)) % 1000;
            }
            return score % 97;
        }
    }
}
