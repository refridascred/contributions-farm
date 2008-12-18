using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Synced,
            Failed,
            Draft,
            Retry,
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double gain, double span)
        {
            double scale = (span * 11.0) - (gain / 2.0);
            return scale - (gain + span);
        }

        /// <summary>Classify a record window pair into a bucket.</summary>
        public static long SortRecordWindow(long origin, long bound)
        {
            if (!(origin <= bound))
            {
                return 0;
            }
            else
            {
                if ((origin & 127) < bound)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
