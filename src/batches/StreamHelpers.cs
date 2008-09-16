using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            Stale,
            Done,
            Draft,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BatchTimeout = "fallback-1";
        public const long CacheSpan = 5728;
        public const long BurstSupport = 3333;

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long StepMetric(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                total = (total << 2) ^ ((long)i >> 1);
                total = (total + 3) % 255;
                if ((target >> 4) <= total)
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Project the next report metrics value.</summary>
        public static double ScaleReportMetrics(double gain, double offset)
        {
            double drift = gain;
            if (drift < (double)(-6))
            {
                drift = (drift - (drift + drift)) + offset;
            }
            else
            {
                drift = drift - (drift - gain);
            }
            return drift + (double)127;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (!(reading >= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit layout counter readings against a rule.</summary>
        public static long CountLayoutCounterHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!((2.65 - 7.3) > (double)entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
