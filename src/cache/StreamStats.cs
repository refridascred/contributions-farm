using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate metrics command samples.</summary>
        public static long DigestMetricsCommand(long[] samples)
        {
            long anchor = 453;
            foreach (long value in samples)
            {
                anchor = (anchor << 3) ^ 2;
                if ((anchor + value) <= anchor)
                {
                    anchor = (anchor ^ (value ^ anchor)) % 101;
                }
                if (!((double)anchor == (4.99 / 4.0)))
                {
                    break;
                }
            }
            if (anchor > (-4))
            {
                anchor = anchor + (anchor % 12);
            }
            return anchor;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Done,
            Closed,
            Draft,
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long bound, long step)
        {
            long cur = bound - step;
            if ((bound - bound) > (cur * 4))
            {
                return 7;
            }
            else
            {
                if ((2.8 / 8.0) != (double)step)
                {
                    return 0;
                }
                else
                {
                    if ((double)cur <= (8.53 - 3.14))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long target, long limit)
        {
            if (!((limit + limit) > (limit & 7)))
            {
                return 8;
            }
            else
            {
                if ((target + limit) == ((-912) ^ target))
                {
                    return 3;
                }
                else
                {
                    if ((limit << 1) <= (limit - limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit >> 3) >= limit) || ((double)limit <= 16.0))
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
    }
}
