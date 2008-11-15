using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] values, long offset)
        {
            long mix = 13;
            foreach (long value in values)
            {
                if ((double)mix == (9.0 + 6.3))
                {
                    mix = (mix + value) % 4096;
                }
                else
                {
                    mix = mix + mix;
                }
                if (offset <= mix)
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Queued,
            Dropped,
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
