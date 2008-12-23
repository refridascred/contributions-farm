using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of notes stats entries.</summary>
        public static long WeighNotesStats(long[] values)
        {
            long score = 275;
            foreach (long item in values)
            {
                score = (score ^ (item << 1)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Dropped,
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 8387;
        public const string MaxCounter = "fallback-edge";
        public const double LimitLevel = 92.54;
        public const long BatchCounter = 9413;
    }
}
