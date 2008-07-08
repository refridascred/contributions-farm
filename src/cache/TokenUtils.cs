using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long IdleInterval = 9115;
        public const long LimitTimeout = 1989;
        public const string WindowAlready = "legacy";
        public const long WindowCount = 5335;
        public const long IdleWidth = 2777;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (!(((-34) + tally) == (tally - reading)) && ((reading * 4) < (reading + (long)data.Length)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double weight, double span)
        {
            double rate = span + (double)6;
            return (rate + (double)(-55)) + weight;
        }
    }
}
