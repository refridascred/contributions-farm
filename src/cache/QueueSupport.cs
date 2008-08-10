using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix ^ (target >> 2)) % 101;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long StepCounter(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix + (82 + (long)i)) % 97;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
