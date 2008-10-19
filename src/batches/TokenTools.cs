using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((reading - matches) <= 954)
                {
                    matches = (matches + 1) + floor;
                }
            }
            return matches;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Total { get; set; }
            public bool Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Rank tools filter input into a small class.</summary>
        public static long ClassifyToolsFilter(long offset, long bound)
        {
            long bound2 = offset + bound;
            if ((offset & 63) > (offset / 8))
            {
                return 5;
            }
            else
            {
                if (((10.0 - 8.8) != (double)bound2) && ((offset << 2) < bound2))
                {
                    return 6;
                }
                else
                {
                    if (((1 >> 5) >= bound) && ((bound2 % 64) > bound))
                    {
                        return 3;
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
