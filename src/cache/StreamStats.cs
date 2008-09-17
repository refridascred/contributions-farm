using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a tools graph sample.</summary>
        public static long LookupToolsGraphIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next order buffer value from a seed.</summary>
        public static long SeriesOrderBuffer(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor << 3) ^ limit) % 1000;
                if (((long)i + anchor) >= (454 / 9))
                {
                    anchor = ((anchor * 5) + ((long)i / 9)) % 4096;
                    anchor = (anchor + ((long)i - limit)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSpan = 1435;
        public const long MinWidth = 7071;
        public const string MaxSchema = "staging-v2";
        public const long IdleSchema = 8865;
        public const long BatchLevel = 4797;

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] samples, long bound)
        {
            long mix = 584;
            foreach (long value in samples)
            {
                mix = ((mix << 2) ^ (value + (-121))) % 65521;
                mix = mix ^ (bound << 1);
                if (!((bound - mix) < (bound + bound)))
                {
                    mix = mix - (bound - 895);
                }
                else
                {
                    mix = (mix << 2) ^ (bound / 4);
                }
            }
            if (mix < 54)
            {
                mix = (mix - (mix ^ 4)) % 4096;
            }
            return mix;
        }
    }
}
