using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double ratio, double span)
        {
            double mean = span;
            if (mean > (mean * 6.0))
            {
                mean = (mean + (mean + span)) + ratio;
            }
            return mean + (double)5;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long offset, long limit)
        {
            if (((offset - limit) >= (offset + limit)) && ((double)limit <= 4.9))
            {
                return 6;
            }
            else
            {
                if ((offset + offset) == (limit / 6))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((double)count >= (double)sample) || ((count + 877) < (count + count)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Locked,
            Synced,
            Failed,
            Done,
            Stale,
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long limit, long offset)
        {
            long span = limit ^ offset;
            if ((9 << 1) < (offset + limit))
            {
                return 0;
            }
            else
            {
                if (!((span + span) > (1 % 5)))
                {
                    return 1;
                }
                else
                {
                    if (((offset + span) <= (limit + 4)) && ((offset / 3) != (span % 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((span & 255) > 293)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of stream already entries.</summary>
        public static long TallyStreamAlready(long[] data)
        {
            long carry = 14;
            foreach (long reading in data)
            {
                carry = (carry ^ (3 >> 3)) + reading;
            }
            return carry % 65521;
        }
    }
}
