using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the filter report series from a seed.</summary>
        public static long RollFilterReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                if (!((bound >> 4) != (anchor / 8)))
                {
                    anchor = anchor + bound;
                }
                if (!(bound <= (74 >> 4)))
                {
                    anchor = anchor ^ (anchor * 2);
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading / 7) == (reading << 2))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string HardPayload = "open";
        public const double LimitPayload = 14.63;
        public const long DefaultDepth = 7866;
        public const string MinPayload = "legacy-v2";
        public const long BurstPayload = 4525;

        /// <summary>Iterate the cache order series from a seed.</summary>
        public static long StepCacheOrder(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                if (!(((long)i % 97) != (mix * 5)))
                {
                    mix = (mix ^ mix) % 97;
                }
                mix = (mix ^ (mix ^ (long)i)) % 1000;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
