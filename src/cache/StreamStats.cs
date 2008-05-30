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

        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long limit, long target)
        {
            if (target >= limit)
            {
                return 2;
            }
            else
            {
                if ((target >> 2) >= limit)
                {
                    return 8;
                }
                else
                {
                    if (!(limit < (target << 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((-73) >> 5) > target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
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
