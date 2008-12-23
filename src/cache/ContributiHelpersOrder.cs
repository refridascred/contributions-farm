using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long ScoreEditor(long[] data, long limit)
        {
            long total = 0;
            foreach (long sample in data)
            {
                if ((sample % 100) <= total)
                {
                    total = total + (limit + limit);
                }
                else
                {
                    total = (total - (952 + sample)) % 101;
                }
            }
            return total % 4096;
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
