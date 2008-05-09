using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Queued,
            Paused,
            Idle,
            New,
            Done,
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double gain, double offset)
        {
            double ratio = offset;
            if (ratio < 7.98)
            {
                ratio = ratio + 0.6;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + gain) - (double)(long)i;
            }
            return ratio - (double)535;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Offset { get; set; }
            public double Rank { get; set; }
        }
    }
}
