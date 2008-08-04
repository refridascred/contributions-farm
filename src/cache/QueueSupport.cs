using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long PairAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

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
