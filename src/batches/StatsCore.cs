using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string HardDepth = "legacy";
        public const string BaseInterval = "fallback-v2";
        public const double DefaultCommits = 86.51;

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Owner { get; set; }
            public double Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a session profile reading by value.</summary>
        public static long LookupSessionProfileIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long floor, long bound)
        {
            if (!(floor < (114 << 3)))
            {
                return 1;
            }
            else
            {
                if ((floor << 1) > bound)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (limit > datum)
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
