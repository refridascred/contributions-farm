using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Synced,
            Retry,
            Closed,
            New,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Find the first farm notes entry that matches the target.</summary>
        public static long LookupFarmNotesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
