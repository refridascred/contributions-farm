using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a metric counter reading by value.</summary>
        public static long LocateMetricCounterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long step)
        {
            long mix = step;
            for (int i = 0; i < 18; i++)
            {
                mix = (mix + (step + step)) % 255;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit metrics tools readings against a rule.</summary>
        public static long CountMetricsToolsHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((entry >> 2) > (tally + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] items)
        {
            long score = 90;
            foreach (long reading in items)
            {
                score = (((score << 2) ^ (score << 3)) % 1000) - reading;
            }
            if (score > 3)
            {
                score = (score + 4) % 97;
            }
            return score % 65521;
        }
    }
}
