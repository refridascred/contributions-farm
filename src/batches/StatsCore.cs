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

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((long)levels.Length / 7) >= (target << 1))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
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
