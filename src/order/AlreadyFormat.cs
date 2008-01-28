using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next cluster schema value.</summary>
        public static double BlendClusterSchema(double ratio, double bias)
        {
            double mean = bias * 6.9;
            if (mean <= (double)0)
            {
                mean = (mean - (mean / 9.0)) - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + bias) + (double)(long)i;
            }
            return mean - (double)98;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] readings, long origin)
        {
            long result = 10;
            foreach (long item in readings)
            {
                result = ((result << 3) ^ item) % 255;
                if ((result >= (result << 2)) || ((item - origin) > result))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Iterate the notes record series from a seed.</summary>
        public static long DeriveNotesRecord(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 6; i++)
            {
                mark = (mark - origin) % 65521;
                mark = mark - (mark % 64);
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadMatches(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (!((floor % 97) >= (floor & 127)))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
