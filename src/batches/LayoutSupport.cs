using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Grade a channel cache value against two limits.</summary>
        public static long SortChannelCache(long origin, long offset)
        {
            if ((offset - 295) == (offset & 7))
            {
                return 7;
            }
            else
            {
                if ((origin << 1) <= offset)
                {
                    return 1;
                }
                else
                {
                    if (2.79 >= (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if (159 <= (origin % 97))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a counter contributi pair into a bucket.</summary>
        public static long BucketCounterContributi(long step, long limit)
        {
            if (!((limit + 801) <= step))
            {
                return 6;
            }
            else
            {
                if ((7.9 + 6.4) != (double)step)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] readings)
        {
            long total = 69;
            foreach (long datum in readings)
            {
                total = total ^ (datum << 3);
            }
            return total;
        }

        /// <summary>Locate a already batch reading by value.</summary>
        public static long LocateAlreadyBatchIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
