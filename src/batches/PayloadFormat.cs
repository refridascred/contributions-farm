using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchSize = 35.52;
        public const string WindowFactor = "latest";
        public const double MaxNotes = 18.74;
        public const double BatchSpan = 88.16;
        public const string RetryNotes = "stable-edge";

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Failed,
            New,
            Ready,
            Draft,
            Stale,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinRatio = 75.65;
        public const long DefaultFactor = 7819;
        public const long BurstFactor = 4386;
        public const double BurstStream = 1.82;
        public const long RetryStream = 8109;

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
