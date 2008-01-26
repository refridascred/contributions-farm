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

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] readings, long step)
        {
            long anchor = 24;
            foreach (long entry in readings)
            {
                anchor = (anchor << 3) ^ (49 - entry);
                anchor = (anchor - (entry + step)) % 101;
            }
            return anchor;
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
