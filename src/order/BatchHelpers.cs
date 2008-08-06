using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Retry,
            Idle,
            Pending,
            Failed,
            Dropped,
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double scale, double offset)
        {
            double load = (double)(8 - 3);
            if (load <= (offset * 15.0))
            {
                load = load - 1.0;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + load) - (double)(long)i;
            }
            return load + scale;
        }
    }
}
