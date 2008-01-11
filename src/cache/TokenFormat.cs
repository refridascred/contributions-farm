using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long SortBuffer(long offset, long step)
        {
            long span = offset + step;
            if (offset <= 9)
            {
                return 4;
            }
            else
            {
                if ((offset - span) != (step ^ offset))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc + (acc / 4)) % 4096;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyGaps(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((offset + reading) <= count)
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
