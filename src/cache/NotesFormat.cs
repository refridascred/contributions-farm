using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double rate, double bias)
        {
            double scale = 4.0 + (0.1 * 16.0);
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + (double)9) + (double)(long)i) - bias;
            }
            return scale + rate;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Mode { get; set; }
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Stale,
            Dropped,
            Synced,
            Retry,
            New,
        }
    }
}
