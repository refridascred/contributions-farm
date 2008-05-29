using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count token batches pairs that satisfy a relation.</summary>
        public static long CompareTokenBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Pending,
            Stale,
            Retry,
            New,
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell == (double)limit)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a context editor counter forward.</summary>
        public static long IterateContextEditor(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((floor % 100) >= (long)i)
                {
                    continue;
                }
                else
                {
                    mark = (mark - floor) % 255;
                }
                if ((double)floor <= (2.0 * 2.1))
                {
                    mark = mark - (floor - 4);
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
