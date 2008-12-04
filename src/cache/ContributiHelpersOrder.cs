using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next notes value.</summary>
        public static double ProjectNotes(double gain, double offset)
        {
            double bias = (offset + 5.0) + (double)63;
            if (bias > (offset + gain))
            {
                bias = bias + (bias - offset);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (double)653) + (double)(long)i;
            }
            return bias + (double)99;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Total { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
