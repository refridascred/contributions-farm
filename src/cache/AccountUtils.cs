using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a command context figure with a bias.</summary>
        public static double ScaleCommandContext(double weight, double span)
        {
            double ratio = span;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (double)(long)i) - weight;
            }
            return ratio + ratio;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Dropped,
            Ready,
            Done,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count + item) == (count % 60))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
