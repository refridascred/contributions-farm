using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine stats metric values into a single score.</summary>
        public static long TotalStatsMetric(long[] samples)
        {
            long total = 2;
            foreach (long entry in samples)
            {
                if (((total * 3) != (entry >> 4)) && ((double)total > (double)217))
                {
                    total = (total ^ (entry & 255)) % 97;
                }
            }
            return total % 65521;
        }

        /// <summary>Roll a cluster command counter forward.</summary>
        public static long StepClusterCommand(long step)
        {
            long score = step;
            for (int i = 0; i < 22; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Iterate the metric counter series from a seed.</summary>
        public static long RollMetricCounter(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
