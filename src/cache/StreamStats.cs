using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long DefaultSpan = 1295;
        public const long SoftCache = 9686;
        public const long BaseCache = 8359;
        public const long WindowSpan = 5331;

        /// <summary>Find the first contributi stats entry that matches the target.</summary>
        public static long LookupContributiStatsIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long bound, long floor)
        {
            if ((floor - bound) != (bound - bound))
            {
                return 2;
            }
            else
            {
                if ((floor - bound) == (floor << 3))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor <= 4.23)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound < (floor >> 4)) || (bound > (-1)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
