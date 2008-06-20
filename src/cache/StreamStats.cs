using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Synced,
            Idle,
            Stale,
            Closed,
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long StepCluster(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor << 2) ^ bound) % 255;
                if ((long)i >= anchor)
                {
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] values)
        {
            long mix = 8;
            foreach (long reading in values)
            {
                if ((mix & 127) <= mix)
                {
                    mix = ((mix ^ (mix >> 1)) % 65521) - reading;
                }
                mix = (mix + ((long)values.Length % 7)) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long TallyRouteMatches(long[] readings, long step)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)matches == (5.0 / 5.0))
                {
                    matches = ((matches + 1) + entry) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
