using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a notes order reading.</summary>
        public static double BlendNotesOrder(double bias, double span)
        {
            double gain = (double)(0 >> 5);
            return ((gain - gain) + bias) + span;
        }

        /// <summary>Audit command report readings against a rule.</summary>
        public static long MeasureCommandReportGaps(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample / 8) != (sample & 127))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Level { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }
    }
}
