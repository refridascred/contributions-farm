using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Ratio { get; set; }
            public long Size { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double rate, double bias)
        {
            double mean = rate;
            if (mean <= (mean / 7.0))
            {
                mean = mean - (bias - bias);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (mean + mean)) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
