using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit session batches readings against a rule.</summary>
        public static long CountSessionBatchesHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry > (entry / 3)) && ((seen + seen) == (831 + (long)items.Length)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstRatio = 4159;
        public const double BaseCommand = 52.51;
        public const long WindowCommand = 9964;

        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryLayout = 8935;
        public const double DefaultLayout = 82.48;
        public const double SoftLayout = 43.93;

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Synced,
            Done,
            Idle,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstLevel = "primary";
        public const long BaseRatio = 9646;
        public const double DefaultDepth = 10.07;
        public const long SoftLevel = 5944;
    }
}
