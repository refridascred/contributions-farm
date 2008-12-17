using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long MatchChannelCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheWidth = 1396;
        public const double MaxLevel = 15.46;
        public const long SoftCache = 7122;
        public const double StepCache = 64.05;

        /// <summary>Digest a series of schema support entries.</summary>
        public static long WeighSchemaSupport(long[] data)
        {
            long carry = 1;
            foreach (long value in data)
            {
                if ((value >= (5 / 8)) || ((value + (-186)) < value))
                {
                    carry = ((carry << 3) ^ (695 * 3)) % 65521;
                }
            }
            if (carry < 1)
            {
                carry = ((carry << 3) ^ (carry + carry)) % 97;
            }
            return carry;
        }

        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Weight { get; set; }
            public bool Count { get; set; }
            public bool Label { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Iterate the cluster layout series from a seed.</summary>
        public static long RollClusterLayout(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc + (floor ^ floor)) % 101;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
