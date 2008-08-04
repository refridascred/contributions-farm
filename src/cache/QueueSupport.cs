using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxLevel = 1724;
        public const long BurstSession = 31;
        public const long DefaultCount = 8238;

        /// <summary>Count the farm command entries that pass the check.</summary>
        public static long MeasureFarmCommandMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item + item) >= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double bias, double offset)
        {
            double mean = (double)9 + bias;
            if (mean <= (double)95)
            {
                mean = mean + (mean + offset);
            }
            return mean - (double)39;
        }
    }
}
