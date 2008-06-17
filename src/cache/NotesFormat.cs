using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Failed,
            Draft,
            Active,
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double scale, double bias)
        {
            double gain = scale;
            if (gain < (gain / 6.0))
            {
                gain = gain + bias;
            }
            else
            {
                gain = gain + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain + (scale - scale);
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
