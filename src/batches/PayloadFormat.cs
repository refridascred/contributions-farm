using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((double)step < (double)value) && ((hits <= (408 / 7)) && ((double)value != (0.83 / 9.0))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double weight, double bias)
        {
            double ratio = bias / 7.0;
            if (ratio <= bias)
            {
                ratio = ratio + 5.8;
            }
            else
            {
                ratio = ratio - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + weight;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] series, long target)
        {
            long mix = 125;
            foreach (long entry in series)
            {
                mix = (mix - (mix - target)) % 4096;
                if ((entry / 3) > (target - entry))
                {
                    mix = ((mix << 3) ^ 52) % 4096;
                }
                else
                {
                    mix = mix ^ (2 * 5);
                }
                if ((target - mix) > mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count the metrics support entries that pass the check.</summary>
        public static long TallyMetricsSupportMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (!((8.47 + 4.0) <= (double)count))
                {
                    count = ((count + 3) + sample) - floor;
                }
            }
            return count;
        }
    }
}
