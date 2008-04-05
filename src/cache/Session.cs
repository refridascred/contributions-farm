using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a cache session sample.</summary>
        public static long FindCacheSessionIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout batch entries.</summary>
        public static long DigestLayoutBatch(long[] levels, long limit)
        {
            long carry = 8;
            foreach (long cell in levels)
            {
                carry = (((carry * 3) + cell) % 65521) + limit;
            }
            return carry;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Total { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
        }
    }
}
