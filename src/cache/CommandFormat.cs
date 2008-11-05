using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((item >> 1) > item)
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long limit, long limit2)
        {
            long diff = limit - limit2;
            if ((7.9 - 6.0) > (double)limit)
            {
                return 6;
            }
            else
            {
                if ((limit * 4) == (limit << 2))
                {
                    return 2;
                }
                else
                {
                    if (!((limit2 - diff) > limit2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((double)diff <= (20.0 - 2.0)) && (limit2 <= (6 - 4)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double AdjustStream(double bias, double bias2)
        {
            double load = 5.28;
            for (int i = 0; i < 7; i++)
            {
                load = (((load + (2.81 / 7.0)) + (double)(long)i) - bias) - bias2;
            }
            return load + 5.4;
        }
    }
}
