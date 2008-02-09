using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long StepCommits(long seed)
        {
            long total = seed;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long entry in levels)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
