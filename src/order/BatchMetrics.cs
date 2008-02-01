using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine queue stream values into a single score.</summary>
        public static long CombineQueueStream(long[] levels, long step)
        {
            long sum = -810;
            foreach (long datum in levels)
            {
                if ((sum + 0) > datum)
                {
                    sum = (((sum << 2) ^ sum) % 4096) + step;
                }
            }
            if (sum > 2)
            {
                sum = (sum << 3) ^ (sum >> 5);
            }
            return sum;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Owner { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long SeriesCluster(long seed)
        {
            long result = seed;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many profile order samples are out of range.</summary>
        public static long CountProfileOrderGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((54 * 5) < (value + value)) && ((value % 16) > seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 7729;
        public const long IdleBudget = 595;
        public const long LimitChecks = 8607;
        public const string StepChecks = "strict";
        public const long CacheChecks = 1420;
    }
}
