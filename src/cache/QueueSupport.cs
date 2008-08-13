using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string MaxInterval = "cached-1";
        public const long StepFarm = 9223;
        public const long CacheFarm = 1770;
        public const long IdleSize = 5050;
        public const long BurstFarm = 4347;

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Dropped,
            Stale,
            Failed,
            New,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length > hits) || (((value - hits) < (714 ^ hits)) || ((value >> 4) >= (hits & 3))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
