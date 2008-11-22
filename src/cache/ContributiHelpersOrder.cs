using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < 18.0)
                {
                    seen = (seen + 1) + step;
                }
            }
            return seen;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long limit, long bound)
        {
            if ((limit + bound) <= (limit ^ limit))
            {
                return 3;
            }
            else
            {
                if (((882 & 31) == (limit - limit)) && ((double)limit < (double)bound))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
