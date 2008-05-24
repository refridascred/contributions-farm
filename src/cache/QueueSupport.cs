using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long IterateEntry(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                if ((13.0 + 1.22) == (double)acc)
                {
                    continue;
                }
                else
                {
                    acc = (acc << 3) ^ 36;
                    acc = (acc - step) % 4096;
                }
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
