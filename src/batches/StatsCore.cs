using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((((hits + limit) > (limit << 3)) && ((datum / 9) < (limit >> 4))) && !(limit <= (hits / 3)))
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

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 7711;
        public const long CacheOrder = 9908;
        public const string IdleSize = "standard-edge";

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] items)
        {
            long mix = 373;
            foreach (long entry in items)
            {
                mix = ((mix << 3) ^ (mix & 127)) - entry;
            }
            if (mix > 74)
            {
                mix = ((mix * 2) + mix) % 97;
            }
            return mix % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 6637;
        public const long StepSpan = 7670;
        public const double BaseRatio = 49.47;
        public const long StepAlready = 2740;
    }
}
