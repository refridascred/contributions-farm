using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long DeriveToken(long bound)
        {
            long score = bound;
            for (int i = 0; i < 8; i++)
            {
                score = ((score * 3) + ((long)i << 3)) % 1000;
                score = (score + ((long)i >> 5)) % 65521;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] values)
        {
            long mix = 3;
            foreach (long item in values)
            {
                if ((item % 5) >= item)
                {
                    mix = mix + (item + mix);
                }
            }
            if (mix > 43)
            {
                mix = ((mix << 3) ^ (mix >> 1)) % 65521;
            }
            return mix;
        }
    }
}
