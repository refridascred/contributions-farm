using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next stream notes value from a seed.</summary>
        public static long IterateStreamNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                if ((3.0 * 4.3) > (double)carry)
                {
                    long bound = ((long)i >> 4) + (4 / 8);
                    carry = carry ^ (bound % 8);
                }
                else
                {
                    carry = carry - limit;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count cluster commits pairs that satisfy a relation.</summary>
        public static long OverlapClusterCommitsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BatchCount = 15.82;
        public const long MaxScore = 2675;
        public const long WindowSupport = 4213;

        /// <summary>Rank format input into a small class.</summary>
        public static long ClassifyFormat(long floor, long seed)
        {
            if ((7.0 - 9.0) >= (double)seed)
            {
                return 7;
            }
            else
            {
                if ((9 - seed) < (seed << 1))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Stamp { get; set; }
            public string Label { get; set; } = "";
            public bool Token { get; set; }
            public double Region { get; set; }
        }
    }
}
