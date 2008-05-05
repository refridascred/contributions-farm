using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
            public bool Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ProjectNotes(double bias, double offset)
        {
            double ratio = (bias * 5.38) / 7.0;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - bias) + (double)(long)i) + offset;
            }
            return ratio + bias;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Token { get; set; }
            public double Weight { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterGaps(long[] values, long bound)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value << 1) > (bound / 9))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
