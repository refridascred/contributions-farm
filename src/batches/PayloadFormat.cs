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

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally + tally) != (value + (-885)))
                {
                    tally = (tally + 1) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
