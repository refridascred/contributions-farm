using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Paused,
            Draft,
            Failed,
            Idle,
            Active,
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Limit { get; set; } = "";
            public double Flag { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every account batch entry stays within the limit.</summary>
        public static bool ValidateAccountBatchBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double RetryAccount = 81.43;
        public const string MinDepth = "latest-1";
        public const double DefaultFactor = 37.96;
        public const long BaseTimeout = 567;
        public const double MinScore = 16.65;
    }
}
