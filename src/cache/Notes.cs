using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public bool Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Classify a tools payload pair into a bucket.</summary>
        public static long RankToolsPayload(long origin, long limit)
        {
            long prev = origin - limit;
            if (prev >= (68 >> 1))
            {
                return 1;
            }
            else
            {
                if (limit <= (prev << 1))
                {
                    return 0;
                }
                else
                {
                    if ((limit % 5) >= (limit + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((prev >= (prev - prev)) && ((double)8 < (double)origin))
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

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long sample in levels)
            {
                if (sample >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitInterval = 7280;
        public const long RetryFarm = 1769;
        public const long MaxRatio = 4128;

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Synced,
            Queued,
            Closed,
            Draft,
            Active,
        }
    }
}
