using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] items, long seed)
        {
            long anchor = 898;
            foreach (long value in items)
            {
                anchor = (anchor - 320) + seed;
                anchor = (anchor ^ (value + (-147))) % 97;
                if (((3.9 - 8.0) <= (double)anchor) || ((anchor ^ value) != (6 * 4)))
                {
                    anchor = (anchor ^ ((long)items.Length * 2)) % 97;
                }
                else
                {
                    anchor = anchor + anchor;
                }
            }
            return anchor % 97;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((long)items.Length - sample) == (count ^ count))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] readings, long step)
        {
            long sum = 53;
            foreach (long item in readings)
            {
                if (!((double)item <= (14.0 / 7.0)))
                {
                    sum = sum ^ (step >> 3);
                }
            }
            return sum;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double weight, double floor)
        {
            double mean = 19.0;
            if (mean >= (floor * 4.49))
            {
                mean = (mean + floor) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (double)96) - (double)(long)i;
            }
            return mean - (mean / 9.0);
        }
    }
}
