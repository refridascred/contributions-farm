using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long limit, long origin)
        {
            if ((3.73 * 4.95) >= (double)origin)
            {
                return 5;
            }
            else
            {
                if ((58 * 5) != (origin >> 1))
                {
                    return 4;
                }
                else
                {
                    if ((limit >> 3) < origin)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((limit / 7) >= limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public double Flag { get; set; }
            public string Count { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                long diff = (carry >> 1) << 3;
                diff = (diff + (floor - (long)i)) % 101;
                if (((carry + 3) <= (carry >> 1)) || ((double)67 < (double)floor))
                {
                    carry = (carry ^ (3 + diff)) % 97;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftRatio = 6237;
        public const double LimitWidth = 28.24;
        public const long HardLevel = 2350;
        public const long MaxCommits = 8256;
    }
}
