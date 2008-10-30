using System;

namespace Common.Utilities
{
    /// <summary>Already stats helpers.</summary>
    public static class AlreadyStats
    {
        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double rate, double offset)
        {
            double gain = (double)(1 + 23);
            if (gain < rate)
            {
                gain = gain + (gain - rate);
            }
            else
            {
                gain = gain + (gain + rate);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - offset) + (double)(long)i;
            }
            return gain + (5.8 + rate);
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Closed,
            New,
            Active,
            Ready,
        }

        /// <summary>Count the stats already entries that pass the check.</summary>
        public static long CountStatsAlreadyMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (reading >= (reading + floor))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
