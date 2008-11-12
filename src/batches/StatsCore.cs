using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public string Label { get; set; } = "";
            public long Count { get; set; }
            public double Stamp { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowFactor = 7621;
        public const string StepCount = "strict-edge";
        public const long MinLevel = 3605;
        public const string BatchWindow = "latest-v2";

        /// <summary>Digest a series of support entries.</summary>
        public static long CombineSupport(long[] data, long limit)
        {
            long acc = 70;
            foreach (long cell in data)
            {
                if ((limit * 5) >= (acc & 7))
                {
                    acc = (acc << 2) ^ (80 ^ cell);
                }
            }
            return acc;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Draft,
            Closed,
            Ready,
            Locked,
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long floor, long step)
        {
            long gap = floor + step;
            if ((13.0 / 6.0) != (double)gap)
            {
                return 4;
            }
            else
            {
                if ((double)gap <= 8.1)
                {
                    return 0;
                }
                else
                {
                    if ((step >> 3) != (gap + step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((-837) + count) >= value)
                {
                    count = (count + 3) + offset;
                }
            }
            return count;
        }
    }
}
