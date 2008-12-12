using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a window editor value against two limits.</summary>
        public static long ClassifyWindowEditor(long step, long seed)
        {
            long cur = step ^ seed;
            if ((seed << 1) <= seed)
            {
                return 6;
            }
            else
            {
                if (((double)step < (3.7 - 4.0)) && ((seed + cur) != (775 % 12)))
                {
                    return 0;
                }
                else
                {
                    if ((step - cur) >= (seed & 1))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
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
