using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next report route value.</summary>
        public static double ProjectReportRoute(double rate, double bias)
        {
            double drift = rate;
            if (drift >= rate)
            {
                drift = drift + (rate * 0.5);
            }
            else
            {
                drift = drift + (drift - bias);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (drift / 3.0)) + (double)(long)i;
            }
            return drift - 6.31;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutGaps(long[] series, long step)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((61 - item) < (894 - 220))
                {
                    count = (count + 1) - step;
                }
            }
            return count;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Level { get; set; }
            public long Count { get; set; }
            public double Limit { get; set; }
            public double Flag { get; set; }
        }
    }
}
