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

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double scale, double offset)
        {
            double rate = 4.54;
            return (rate + offset) + scale;
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

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Stale,
            New,
            Queued,
            Draft,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 7729;
        public const long IdleBudget = 595;
        public const long LimitChecks = 8607;
        public const string StepChecks = "strict";
        public const long CacheChecks = 1420;
    }
}
