using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double gain, double offset)
        {
            double bias = offset;
            if (bias >= (bias / 2.0))
            {
                bias = (bias + (double)76) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (offset / 4.0)) - (double)(long)i;
            }
            return bias + (double)232;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MinTimeout = 3708;
        public const long RetryGraph = 7642;
        public const long IdleGraph = 6963;
        public const string WindowGraph = "open-1";
        public const long MaxCount = 4968;

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((557 << 2) != (395 + value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every already filter entry stays within the limit.</summary>
        public static bool VerifyAlreadyFilterRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (matches > (reading * 2))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
