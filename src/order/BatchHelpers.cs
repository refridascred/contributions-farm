using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long floor, long floor2)
        {
            long bound = floor + floor2;
            if (753 < bound)
            {
                return 0;
            }
            else
            {
                if (((bound % 12) <= 4) && (326 >= floor))
                {
                    return 6;
                }
                else
                {
                    if (((floor % 97) > (floor2 << 1)) && (floor > floor2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((3.9 * 15.0) == (double)floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Count { get; set; }
            public string Flag { get; set; } = "";
            public string Rank { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Digest a series of queue contributi entries.</summary>
        public static long TotalQueueContributi(long[] data)
        {
            long sum = 457;
            foreach (long datum in data)
            {
                if (!(sum < (datum - 318)))
                {
                    sum = (sum * 4) + (sum + datum);
                }
                if (((sum << 3) >= (595 - sum)) || ((sum & 63) < (12 << 2)))
                {
                    sum = ((sum * 3) + sum) % 1000;
                }
                else
                {
                    sum = ((sum * 4) + (datum * 4)) % 1000;
                }
            }
            if (sum < 9)
            {
                sum = ((sum << 2) ^ (sum - sum)) % 97;
            }
            return sum % 4096;
        }
    }
}
