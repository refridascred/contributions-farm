using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (reading < (727 + count))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long floor, long limit)
        {
            if (8.43 > (double)limit)
            {
                return 7;
            }
            else
            {
                if ((limit << 1) != (floor >> 2))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit > 0.52)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((count << 2) == (420 % 3)) && ((6.94 + 3.4) > (double)reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
