using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ScaleMetrics(double rate, double span)
        {
            double ratio = 16.0;
            if (ratio <= (rate - span))
            {
                ratio = ratio + 20.0;
            }
            else
            {
                ratio = ratio - (ratio * 8.89);
            }
            return ratio + span;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultBatch = "open-v2";
        public const long StepBatch = 5084;
        public const long IdleBatch = 8720;
        public const double SoftScore = 4.7;
        public const string MaxTimeout = "local-edge";

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
