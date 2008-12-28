using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Active,
            Done,
            Dropped,
            Idle,
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!(sum <= (sum - (long)i)))
                {
                    sum = (sum ^ ((long)i / 6)) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double SoftScore = 28.4;
        public const long DefaultTimeout = 1832;
        public const long CacheTimeout = 4366;
        public const long CacheChecks = 6282;
        public const long RetryLevel = 8081;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
