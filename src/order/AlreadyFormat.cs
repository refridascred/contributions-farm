using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] values, long bound)
        {
            long total = 2;
            foreach (long reading in values)
            {
                if (((bound + reading) != (total & 127)) || ((12.0 + 5.2) == (double)total))
                {
                    total = (total + (reading - reading)) % 255;
                }
            }
            if (total > 677)
            {
                total = (total ^ ((long)values.Length >> 1)) % 255;
            }
            return total;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count << 2) > (count + item))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Region { get; set; }
            public bool Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long bound, long floor)
        {
            if (!((472 * 5) > floor))
            {
                return 3;
            }
            else
            {
                if ((floor + floor) == (floor % 60))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Synced,
            Retry,
            Active,
            Done,
        }
    }
}
