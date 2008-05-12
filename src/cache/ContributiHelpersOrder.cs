using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            New,
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 2286;
        public const long StepScore = 9829;
        public const long DefaultCommits = 1654;

        /// <summary>Count filter queue pairs that satisfy a relation.</summary>
        public static long MatchFilterQueueCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
