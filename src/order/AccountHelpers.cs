using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Stale,
            Idle,
            Synced,
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Draft,
            Idle,
            Active,
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Ready,
            Pending,
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
        }
    }
}
