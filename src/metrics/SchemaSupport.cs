using System;

namespace Common.Utilities
{
    /// <summary>Schema support helpers.</summary>
    public static class SchemaSupport
    {
        /// <summary>Define booking limits and defaults.</summary>
        public const long SoftBudget = 548;
        public const long MaxScore = 2829;
        public const long MinFactor = 5644;

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long floor, long origin)
        {
            long diff = floor - origin;
            if (((double)diff >= (7.0 / 7.0)) && ((diff << 2) > floor))
            {
                return 8;
            }
            else
            {
                if ((double)origin > (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (((0.1 - 11.0) >= (double)floor) && (origin > (diff + 36)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
