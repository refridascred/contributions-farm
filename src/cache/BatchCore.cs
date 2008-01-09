using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Token { get; set; }
            public double Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Closed,
            Idle,
            Done,
            Dropped,
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double weight, double bias)
        {
            double drift = bias + (bias - bias);
            if (drift <= (double)9)
            {
                drift = drift - weight;
            }
            else
            {
                drift = drift + bias;
            }
            return drift - (bias - 9.0);
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Total { get; set; } = "";
            public bool Score { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }
    }
}
