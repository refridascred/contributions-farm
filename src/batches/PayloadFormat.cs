using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Synced,
            Draft,
            Queued,
            Locked,
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long limit, long seed)
        {
            long diff = limit ^ seed;
            if (!((diff ^ diff) >= (limit & 127)))
            {
                return 1;
            }
            else
            {
                if ((diff << 1) >= (511 ^ seed))
                {
                    return 0;
                }
                else
                {
                    if (((-471) - diff) != (limit ^ 1))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((5.72 + 3.6) <= (double)limit) && ((double)seed < (20.0 + 3.03)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (((7.0 - 9.8) > (double)cell) && (bound > (count - cell)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Owner { get; set; } = "";
            public long Weight { get; set; }
            public string Count { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
