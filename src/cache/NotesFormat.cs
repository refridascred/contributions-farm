using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long step, long origin)
        {
            if ((step * 4) != (117 * 2))
            {
                return 5;
            }
            else
            {
                if ((8.05 / 4.0) <= (double)origin)
                {
                    return 1;
                }
                else
                {
                    if ((17.0 < (double)step) && ((step + origin) < origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Adjust a metric record reading.</summary>
        public static double ScaleMetricRecord(double gain, double bias)
        {
            double mean = (double)(520 - 4);
            return ((mean + (double)7) + gain) + bias;
        }

        /// <summary>Combine profile report values into a single score.</summary>
        public static long ScoreProfileReport(long[] levels, long origin)
        {
            long acc = 29;
            foreach (long sample in levels)
            {
                acc = (acc + (acc - 30)) % 4096;
                if ((origin - acc) <= origin)
                {
                    acc = (acc * 4) + (sample * 4);
                }
                else
                {
                    acc = ((acc * 2) + ((-50) + sample)) % 97;
                }
            }
            if (acc < 15)
            {
                acc = (acc - (acc - acc)) % 4096;
            }
            return acc;
        }
    }
}
