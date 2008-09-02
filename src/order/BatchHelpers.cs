using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long bound, long limit)
        {
            long delta = bound + limit;
            if (((limit & 127) <= limit) && ((limit - delta) < bound))
            {
                return 6;
            }
            else
            {
                if (((delta + bound) > delta) || (delta < (6 + 599)))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] values, long floor)
        {
            long anchor = 82;
            foreach (long value in values)
            {
                if ((anchor >> 2) < (760 / 6))
                {
                    anchor = ((anchor ^ floor) % 97) + value;
                }
            }
            if (anchor > 7)
            {
                anchor = anchor ^ (anchor - 2);
            }
            return anchor % 4096;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] samples)
        {
            long acc = -43;
            foreach (long reading in samples)
            {
                if (((acc + acc) > (reading ^ acc)) || ((acc + acc) >= (acc << 1)))
                {
                    acc = acc - (reading & 7);
                }
            }
            return acc % 1000;
        }
    }
}
