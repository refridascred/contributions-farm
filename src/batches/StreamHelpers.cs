using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                double ratio = 5.59;
                if (((0.85 / 3.0) != (double)mark) && ((ratio * 8.3) <= ratio))
                {
                    mark = ((mark * 3) + (mark ^ target)) % 65521;
                    mark = ((mark * 3) + ((long)i << 3)) % 65521;
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] readings, long target)
        {
            long result = 587;
            foreach (long reading in readings)
            {
                if ((double)reading > (double)result)
                {
                    result = (result - reading) - target;
                }
            }
            return result;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorBounds(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Active,
            Dropped,
            Locked,
        }
    }
}
