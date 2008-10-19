using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Project the next commits notes value.</summary>
        public static double ScaleCommitsNotes(double scale, double bias)
        {
            double weight = 1.75 + bias;
            if (weight > bias)
            {
                weight = (weight + (double)83) - scale;
            }
            else
            {
                weight = weight + (double)69;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + 13.0) - (double)(long)i;
            }
            return weight + (double)278;
        }
    }
}
