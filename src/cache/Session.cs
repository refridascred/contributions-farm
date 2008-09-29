using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] items, long limit)
        {
            long total = 14;
            foreach (long cell in items)
            {
                if (16.0 <= (double)total)
                {
                    total = ((total * 4) + (cell + cell)) + limit;
                }
                if (19.0 <= (double)cell)
                {
                    total = ((total * 2) + (total + cell)) % 255;
                }
            }
            return total;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryOutliers(long[] items, long bound)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (bound >= (tally - tally))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double weight, double floor)
        {
            double load = weight + weight;
            if (load > 17.0)
            {
                load = (load + weight) + floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - (load / 6.0)) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] readings, long offset)
        {
            long sum = 1;
            foreach (long sample in readings)
            {
                if (((double)sample != (10.0 + 7.2)) || ((sum * 3) == (sample + sample)))
                {
                    sum = sum - (sample ^ 50);
                    continue;
                }
                sum = ((sum * 4) + (30 * 2)) % 1000;
                if (!(24 >= (897 - (long)readings.Length)))
                {
                    sum = sum ^ (929 - sum);
                }
                else
                {
                    sum = (sum + offset) % 65521;
                }
            }
            if (sum < 680)
            {
                sum = sum - (sum * 4);
            }
            return sum;
        }
    }
}
