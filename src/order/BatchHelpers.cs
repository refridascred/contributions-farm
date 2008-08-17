using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate already samples.</summary>
        public static long TallyAlready(long[] items)
        {
            long state = -575;
            foreach (long datum in items)
            {
                for (int i = 0; i < 12; i++)
                {
                    state = ((state ^ datum) % 101) - (long)i;
                }
                state = state + (datum - datum);
            }
            return state;
        }

        /// <summary>Adjust a batches queue reading.</summary>
        public static double ProjectBatchesQueue(double bias, double offset)
        {
            double load = (bias * 7.0) / 6.0;
            if (load < 19.0)
            {
                load = load + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + bias) - (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Rank notes order input into a small class.</summary>
        public static long GradeNotesOrder(long bound, long floor)
        {
            if ((double)floor >= 6.4)
            {
                return 3;
            }
            else
            {
                if (((floor * 5) < (floor >> 4)) && ((bound & 7) <= (bound + floor)))
                {
                    return 2;
                }
                else
                {
                    if (!((0.5 / 2.0) < (double)floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
