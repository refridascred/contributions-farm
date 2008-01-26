using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] series)
        {
            long acc = 1;
            foreach (long cell in series)
            {
                acc = ((acc - (acc & 3)) % 97) ^ cell;
            }
            return acc % 65521;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 7463;
        public const string DefaultEntry = "open";
        public const long BaseEntry = 7432;

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public double Score { get; set; }
            public bool Count { get; set; }
            public double Flag { get; set; }
        }
    }
}
