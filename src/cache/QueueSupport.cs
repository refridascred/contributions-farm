using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] samples, long bound)
        {
            long anchor = -522;
            foreach (long item in samples)
            {
                anchor = ((anchor << 2) ^ (bound - bound)) ^ item;
                anchor = (anchor + ((long)samples.Length ^ 47)) % 101;
            }
            if (anchor > 42)
            {
                anchor = anchor - (bound + bound);
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxDepth = 1050;
        public const long CacheProfile = 8109;
        public const double BatchProfile = 92.65;
        public const long StepProfile = 5010;
    }
}
