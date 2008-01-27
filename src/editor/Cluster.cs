using System;

namespace Common.Utilities
{
    /// <summary>Cluster helpers.</summary>
    public static class Cluster
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphMatches(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!(((reading ^ reading) > ((-2) << 2)) && (((-4) >> 4) >= (reading & 3))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] series)
        {
            long mix = -343;
            foreach (long value in series)
            {
                if (((0 & 3) > mix) || (value < (mix - mix)))
                {
                    mix = ((mix << 3) ^ (4 % 16)) % 97;
                }
                mix = mix - (value ^ value);
            }
            return mix;
        }
    }
}
