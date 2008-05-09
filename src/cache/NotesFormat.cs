using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double scale, double span)
        {
            double ratio = 5.0 + (span / 2.0);
            if (ratio > (double)1)
            {
                ratio = (ratio + (2.85 * 18.0)) + scale;
            }
            return ratio + (double)9;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Owner { get; set; }
            public long Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Offset { get; set; }
            public double Rank { get; set; }
        }
    }
}
