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

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheHits(long[] values, long target)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((count * 4) <= (count + count))
                {
                    count = ((count + 3) + entry) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Flag { get; set; }
            public double Weight { get; set; }
        }
    }
}
