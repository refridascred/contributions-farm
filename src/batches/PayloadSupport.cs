using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate tools metrics samples.</summary>
        public static long TallyToolsMetrics(long[] samples)
        {
            long score = 653;
            foreach (long reading in samples)
            {
                score = (score + reading) % 1000;
            }
            return score;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((36 - 61) > (reading << 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= bound) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
