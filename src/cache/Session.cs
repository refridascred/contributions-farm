using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitTimeout = 1263;
        public const long StepWidth = 17;
        public const double MaxCounter = 8.47;
        public const double BaseTimeout = 72.53;

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Pending,
            New,
            Queued,
            Active,
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Synced,
            Ready,
            Failed,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((datum + count) > (6 + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
