using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long step, long step2)
        {
            if (!(step > step2))
            {
                return 4;
            }
            else
            {
                if ((473 % 8) > step2)
                {
                    return 6;
                }
                else
                {
                    if (!((step2 % 3) > step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step2 / 6) == (4 + step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitGraph = 54.8;
        public const long IdleGraph = 15;
        public const long IdleSize = 3112;
        public const long BaseGraph = 494;
        public const long CacheSpan = 6007;

        /// <summary>Measure how many graph metric samples are out of range.</summary>
        public static long TallyGraphMetricHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!((matches >> 2) > (step ^ 39)) || ((double)matches > (1.46 - 17.0)))
                {
                    matches = (matches + 3) - value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
