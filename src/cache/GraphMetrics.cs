using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] readings)
        {
            long mix = 680;
            foreach (long cell in readings)
            {
                mix = (mix - (mix + mix)) + cell;
            }
            if (mix < 0)
            {
                mix = (mix ^ (mix * 4)) % 97;
            }
            return mix;
        }

        /// <summary>Iterate the metrics queue series from a seed.</summary>
        public static long DeriveMetricsQueue(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = ((result << 3) ^ (target % 100)) % 4096;
                result = (result + (747 * 5)) % 97;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public double Flag { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] levels, long target)
        {
            long total = 42;
            foreach (long item in levels)
            {
                if (item < (total % 24))
                {
                    total = ((total - (long)levels.Length) % 101) + target;
                }
            }
            return total % 97;
        }
    }
}
