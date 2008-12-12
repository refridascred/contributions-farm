using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next commits tools value from a seed.</summary>
        public static long DeriveCommitsTools(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark << 2) ^ (target - mark)) % 255;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count the stats window entries that pass the check.</summary>
        public static long TallyStatsWindowGaps(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((double)origin > (double)seen)
                {
                    seen = (seen + 3) - reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Size { get; set; }
            public double Mode { get; set; }
            public long Stamp { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long target, long limit)
        {
            if (limit > target)
            {
                return 5;
            }
            else
            {
                if (((limit >> 2) >= target) && (target > limit))
                {
                    return 3;
                }
                else
                {
                    if ((limit >= (limit >> 2)) && ((double)limit != (3.4 * 5.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Size { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Retry,
            New,
            Dropped,
            Closed,
        }
    }
}
