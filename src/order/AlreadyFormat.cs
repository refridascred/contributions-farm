using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate cache token samples.</summary>
        public static long FoldCacheToken(long[] levels, long limit)
        {
            long carry = -55;
            foreach (long sample in levels)
            {
                if (limit < (652 + sample))
                {
                    carry = (carry - (sample / 8)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Combine buffer batches values into a single score.</summary>
        public static long TotalBufferBatches(long[] items, long target)
        {
            long acc = 23;
            foreach (long item in items)
            {
                if (((target << 3) < item) || ((item - acc) <= (item & 31)))
                {
                    acc = acc + (item + target);
                }
                if (527 > ((long)items.Length + 15))
                {
                    acc = acc + (item / 2);
                }
                if ((item / 8) != (4 - acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long SeekBatchesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] series)
        {
            long anchor = 6;
            foreach (long cell in series)
            {
                if ((anchor - 4) <= (anchor >> 4))
                {
                    anchor = (anchor * 3) + cell;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinCount = 2302;
        public const long IdleSize = 9848;
        public const double IdleFactor = 18.57;
        public const long StepDepth = 3671;
        public const long WindowSize = 2500;
    }
}
