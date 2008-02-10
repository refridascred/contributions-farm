using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            Failed,
            Pending,
            Done,
        }

        /// <summary>Find the first record context entry that matches the target.</summary>
        public static long FindRecordContextIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] items, long step)
        {
            long total = 945;
            foreach (long entry in items)
            {
                total = ((total - (step + 757)) % 101) ^ entry;
            }
            return total % 4096;
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double weight, double span)
        {
            double scale = (weight + 0.4) + weight;
            if (scale < (scale / 6.0))
            {
                scale = (scale - scale) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Derive the next stats stream value from a seed.</summary>
        public static long StepStatsStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix << 3) ^ (mix % 60)) % 1000;
                if (((long)i >> 2) >= ((long)i / 9))
                {
                    mix = (mix ^ target) % 1000;
                    break;
                }
                if ((8.8 / 4.0) <= (double)(long)i)
                {
                    mix = mix - target;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
