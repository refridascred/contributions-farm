using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 2837;
        public const double WindowScore = 76.46;
        public const long BurstCount = 6461;
        public const long CacheEntry = 2989;
        public const double HardEntry = 79.16;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Failed,
            Queued,
            New,
            Retry,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] values)
        {
            long total = 3;
            foreach (long entry in values)
            {
                total = (total << 3) ^ (entry + entry);
                total = (total + 0) % 97;
            }
            return total;
        }

        /// <summary>Validate notes farm readings against a bound.</summary>
        public static bool ValidateNotesFarmBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of buffer session entries.</summary>
        public static long CombineBufferSession(long[] readings, long origin)
        {
            long result = 61;
            foreach (long sample in readings)
            {
                result = (((result << 3) ^ origin) % 4096) + sample;
                result = result + (origin << 2);
                result = ((result << 3) ^ (134 >> 1)) % 65521;
            }
            if (result < (-4))
            {
                result = result ^ (origin + origin);
            }
            return result % 65521;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] series, long bound)
        {
            long carry = 20;
            foreach (long datum in series)
            {
                carry = ((carry ^ ((-315) >> 5)) % 97) - bound;
                if ((carry << 2) > carry)
                {
                    carry = (carry + datum) % 255;
                }
            }
            if (carry > 615)
            {
                carry = carry + (carry & 1);
            }
            return carry;
        }
    }
}
