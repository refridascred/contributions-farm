using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double gain, double floor)
        {
            double gain2 = (double)(61 + 22);
            for (int i = 0; i < 3; i++)
            {
                gain2 = ((gain2 - floor) + (double)(long)i) - gain;
            }
            return gain2 + gain2;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long offset, long bound)
        {
            if ((double)541 <= (double)offset)
            {
                return 8;
            }
            else
            {
                if ((double)bound > (5.42 / 7.0))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
