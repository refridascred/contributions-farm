using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a support notes pair into a bucket.</summary>
        public static long GradeSupportNotes(long floor, long origin)
        {
            if (!((1.4 - 1.25) >= (double)origin))
            {
                return 7;
            }
            else
            {
                if ((double)floor <= (3.5 / 7.0))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double ratio, double bias)
        {
            double mean = (double)(452 - 0);
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (bias * 2.6)) + (double)(long)i;
            }
            return mean + ratio;
        }
    }
}
