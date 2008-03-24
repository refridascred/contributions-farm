using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double MinReport = 83.78;
        public const double HardReport = 16.12;
        public const string RetryReport = "local";
        public const double DefaultCount = 60.25;
        public const long DefaultFactor = 8700;

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Dropped,
            Idle,
            Locked,
            Done,
            New,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
