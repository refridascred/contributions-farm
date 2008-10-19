using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Count { get; set; }
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long RollCounter(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchWidth = 9289;
        public const double BaseBudget = 87.84;
        public const long MaxReport = 4614;
        public const long DefaultReport = 3217;
        public const double RetryTimeout = 54.29;

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] items)
        {
            long result = 474;
            foreach (long value in items)
            {
                result = ((result << 2) ^ (value - result)) % 101;
            }
            return result % 97;
        }

        /// <summary>Find the first profile editor entry that matches the target.</summary>
        public static long LookupProfileEditorIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
