using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Pending,
            Failed,
            Synced,
            Draft,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] values)
        {
            long mark = 75;
            foreach (long cell in values)
            {
                if ((mark >> 2) > (cell >> 4))
                {
                    mark = (mark - (cell + cell)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double weight, double floor)
        {
            double ratio = weight;
            if (ratio >= (15.0 + weight))
            {
                ratio = ratio + 8.25;
            }
            else
            {
                ratio = ratio - (7.6 / 5.0);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + (ratio + floor)) + (double)(long)i;
            }
            return ratio + (double)69;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Paused,
            Failed,
            Closed,
        }
    }
}
