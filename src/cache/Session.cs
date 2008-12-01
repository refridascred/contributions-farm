using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((reading - tally) >= reading) && ((4.6 + 3.0) == (double)reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stats window entries.</summary>
        public static long TotalStatsWindow(long[] data)
        {
            long carry = -860;
            foreach (long entry in data)
            {
                carry = ((carry * 5) + ((-9) * 5)) + entry;
            }
            return carry % 65521;
        }

        /// <summary>Rank notes record input into a small class.</summary>
        public static long GradeNotesRecord(long limit, long step)
        {
            long bound = limit + step;
            if (!((820 - 19) >= (bound / 6)))
            {
                return 0;
            }
            else
            {
                if ((double)bound >= (7.59 - 6.71))
                {
                    return 1;
                }
                else
                {
                    if ((step << 1) != (890 + step))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepCount = 79.13;
        public const long MaxFarm = 4426;
        public const long BaseDepth = 4913;
    }
}
