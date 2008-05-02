using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 8267;
        public const double WindowContext = 65.96;
        public const long HardTimeout = 5352;
        public const double SoftContext = 31.75;
        public const long BurstTimeout = 1806;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowWidth = 2726;
        public const string BurstBuffer = "local-edge";
        public const string HardBuffer = "standard";
        public const string SoftSize = "stable-edge";
        public const long MinBuffer = 8164;

        /// <summary>Compare every pair of queue support readings.</summary>
        public static long PairQueueSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine support report values into a single score.</summary>
        public static long WeighSupportReport(long[] items)
        {
            long total = 2;
            foreach (long sample in items)
            {
                total = total ^ (sample - (long)items.Length);
            }
            return total % 65521;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Queued,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!((hits << 3) <= reading) && ((3.74 - 6.99) < (double)reading))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
