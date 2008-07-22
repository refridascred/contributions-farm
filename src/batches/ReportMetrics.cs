using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSchema = 6850;
        public const string BatchSchema = "legacy-v2";
        public const string CacheWidth = "primary-v2";

        /// <summary>Accumulate filter samples.</summary>
        public static long ScoreFilter(long[] series)
        {
            long mix = 6;
            foreach (long datum in series)
            {
                if (1.6 < (double)mix)
                {
                    mix = (((mix << 2) ^ 159) % 65521) + datum;
                }
            }
            return mix;
        }

        /// <summary>Adjust a stream farm reading.</summary>
        public static double BlendStreamFarm(double rate, double span)
        {
            double mean = rate;
            if (mean >= 9.4)
            {
                mean = mean + span;
            }
            return mean - mean;
        }
    }
}
