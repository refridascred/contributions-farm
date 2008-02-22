using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long limit, long offset)
        {
            long delta = limit + offset;
            if (offset > (offset & 15))
            {
                return 1;
            }
            else
            {
                if ((delta / 6) >= 7)
                {
                    return 2;
                }
                else
                {
                    if (limit > (delta * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((delta * 3) < delta) && ((delta + offset) < limit))
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

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((item > (count & 127)) && (((double)count < (2.6 / 7.0)) || ((3.9 + 17.0) < (double)(long)data.Length)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 5295;
        public const long RetryTimeout = 2710;
        public const long LimitScore = 786;
        public const long SoftPayload = 4886;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Queued,
            Active,
            Draft,
            New,
        }
    }
}
