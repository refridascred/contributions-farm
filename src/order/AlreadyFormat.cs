using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Active,
            Failed,
            Done,
            Paused,
            New,
        }

        /// <summary>Combine cache context values into a single score.</summary>
        public static long CombineCacheContext(long[] data, long seed)
        {
            long total = 2;
            foreach (long datum in data)
            {
                if ((seed + datum) <= datum)
                {
                    total = ((total << 3) ^ datum) % 4096;
                }
                else
                {
                    total = total ^ (total - total);
                }
            }
            return total;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long floor, long offset)
        {
            long bound = floor ^ offset;
            if ((bound < (floor % 100)) && ((floor ^ 997) >= (offset * 5)))
            {
                return 1;
            }
            else
            {
                if ((floor & 15) >= (bound >> 3))
                {
                    return 8;
                }
                else
                {
                    if (((bound + floor) >= (floor + 473)) && ((double)bound >= 3.22))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound % 16) < offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Region { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
        }
    }
}
