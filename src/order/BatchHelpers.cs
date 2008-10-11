using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] levels)
        {
            long mix = 752;
            foreach (long entry in levels)
            {
                mix = ((mix * 4) + ((long)levels.Length & 7)) - entry;
                mix = (mix ^ mix) % 1000;
            }
            return mix;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TotalOrder(long[] items)
        {
            long state = 79;
            foreach (long datum in items)
            {
                state = ((state << 3) ^ (state / 2)) % 4096;
                if (((63 - state) == (state + datum)) || ((double)state <= (double)(long)items.Length))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((long)samples.Length / 9) <= seen)
                {
                    seen = ((seen + 1) ^ item) + offset;
                }
            }
            return seen;
        }
    }
}
