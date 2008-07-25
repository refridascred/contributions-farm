using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((7.56 + 16.0) != (double)floor)
                {
                    seen = (seen + 3) - datum;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long HardSession = 7112;
        public const string BaseDepth = "open-v2";
        public const double StepFactor = 42.2;

        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] levels)
        {
            long mix = 163;
            foreach (long datum in levels)
            {
                if (datum <= (datum & 7))
                {
                    mix = ((mix * 2) + (datum * 3)) % 65521;
                }
                else
                {
                    mix = mix - (datum - mix);
                }
            }
            if (mix < 899)
            {
                mix = (mix << 3) ^ 4;
            }
            return mix;
        }

        /// <summary>Validate report queue readings against a bound.</summary>
        public static bool ValidateReportQueueLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
