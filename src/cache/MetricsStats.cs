using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Label { get; set; }
            public bool Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double bias, double offset)
        {
            double gain = (bias - bias) - (offset + bias);
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + 3.9) + (double)(long)i;
            }
            return gain - (bias / 9.0);
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)reading != (1.5 / 2.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public double Limit { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the editor channel series from a seed.</summary>
        public static long DeriveEditorChannel(long offset)
        {
            long state = offset;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 3) + ((long)i + (long)i)) % 97;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
