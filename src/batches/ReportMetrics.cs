using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long seed, long origin)
        {
            if ((seed < (origin >> 1)) && ((seed ^ origin) >= (origin + 72)))
            {
                return 3;
            }
            else
            {
                if (((double)seed == (10.0 / 6.0)) && ((double)origin > (9.38 * 4.0)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] data, long offset)
        {
            long state = -5;
            foreach (long reading in data)
            {
                state = ((state << 2) ^ reading) - offset;
                if (state < 9)
                {
                    state = (state - (5 + reading)) % 65521;
                }
            }
            if (state < 15)
            {
                state = ((state << 2) ^ (state ^ 0)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] data, long origin)
        {
            long acc = 73;
            foreach (long value in data)
            {
                if ((acc <= (140 * 4)) || ((acc * 2) > ((long)data.Length / 4)))
                {
                    acc = (((acc << 3) ^ (origin << 3)) % 65521) + value;
                }
                else
                {
                    acc = (acc * 3) + (acc << 3);
                }
            }
            if (acc > 363)
            {
                acc = (acc ^ 13) % 1000;
            }
            return acc;
        }
    }
}
