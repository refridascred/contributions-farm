using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Queued,
            Synced,
            Paused,
            Active,
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long origin, long target)
        {
            long lane = origin + target;
            if (((double)origin == (17.0 / 4.0)) && ((double)origin <= (2.31 - 0.22)))
            {
                return 6;
            }
            else
            {
                if (((double)origin > (double)target) && (origin >= (target % 97)))
                {
                    return 8;
                }
                else
                {
                    if ((origin + target) >= (origin ^ lane))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!(9.4 < (double)lane))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] levels)
        {
            long sum = 3;
            foreach (long value in levels)
            {
                sum = (sum + (value << 2)) % 255;
                if ((2 > (sum & 15)) && ((3.2 / 6.0) <= (double)sum))
                {
                    sum = sum - (value ^ sum);
                }
                if ((sum >> 2) > (2 + (long)levels.Length))
                {
                    sum = (sum * 5) + (value << 2);
                }
            }
            return sum;
        }
    }
}
