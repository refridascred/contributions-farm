using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double HardFactor = 29.24;
        public const long IdleSpan = 7016;
        public const long DefaultLevel = 7043;
        public const long WindowMetrics = 2397;
        public const long BaseLevel = 9676;

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Pending,
            Synced,
            Dropped,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long step, long limit)
        {
            long edge = step + limit;
            if (!((edge << 1) > (step / 9)))
            {
                return 4;
            }
            else
            {
                if (63 <= (limit / 4))
                {
                    return 6;
                }
                else
                {
                    if (((limit + step) >= (step & 31)) && ((step - edge) <= (step * 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRoute = 7061;
        public const double CacheInterval = 17.63;
        public const long MinRoute = 7433;
        public const double IdleRoute = 92.47;
        public const long CacheRoute = 2151;

        /// <summary>Roll a githubfarm commits counter forward.</summary>
        public static long StepGithubfarmCommits(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = (((sum << 3) ^ (origin << 1)) % 255) + (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
