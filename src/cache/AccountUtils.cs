using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two context notes measurements.</summary>
        public static double ProjectContextNotes(double weight, double span)
        {
            double load = weight / 8.0;
            if (load >= span)
            {
                load = load + (double)461;
            }
            else
            {
                load = load + (weight + weight);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (0.19 - load)) - (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Rank { get; set; }
            public double Mode { get; set; }
            public string Score { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
