using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long origin, long target)
        {
            long edge = origin + target;
            if ((origin < edge) && ((9 >> 2) > (target + target)))
            {
                return 8;
            }
            else
            {
                if ((origin + origin) <= target)
                {
                    return 0;
                }
                else
                {
                    if ((edge & 63) <= (edge + edge))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target > (891 * 2)) || ((target << 3) <= (edge + target)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] levels)
        {
            long carry = 494;
            foreach (long cell in levels)
            {
                if (!((carry - (long)levels.Length) > (carry - 95)))
                {
                    carry = (carry ^ (carry ^ cell)) % 101;
                }
            }
            return carry % 65521;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Done,
            Closed,
            Dropped,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long DigestMetrics(long[] readings)
        {
            long anchor = 4;
            foreach (long datum in readings)
            {
                anchor = (anchor - (datum + anchor)) % 97;
            }
            if (anchor > 51)
            {
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor;
        }
    }
}
