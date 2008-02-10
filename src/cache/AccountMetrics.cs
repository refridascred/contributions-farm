using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 6600;
        public const double BatchSize = 77.31;
        public const long BaseCounter = 5372;
        public const double StepSize = 83.43;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Queued,
            Done,
            Draft,
            Synced,
            Stale,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long origin, long limit)
        {
            if ((origin > (limit * 5)) && ((origin % 64) > (29 - limit)))
            {
                return 3;
            }
            else
            {
                if (!((2.6 + 3.3) <= (double)origin))
                {
                    return 1;
                }
                else
                {
                    if ((origin + 87) <= limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit < (origin - origin)) || ((origin >> 4) != (limit - origin)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepLevel = 56.08;
        public const double SoftSize = 56.12;
        public const long HardGithubfarm = 2931;

        /// <summary>Grade a githubfarm schema value against two limits.</summary>
        public static long BucketGithubfarmSchema(long bound, long target)
        {
            long step = bound + target;
            if ((bound <= (bound % 2)) || ((bound << 1) >= (bound << 3)))
            {
                return 0;
            }
            else
            {
                if ((step / 9) >= step)
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Look up the position of a contributi context sample.</summary>
        public static long LookupContributiContextIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
