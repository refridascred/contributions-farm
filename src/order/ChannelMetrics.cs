using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] series, long step)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((matches ^ item) <= step) || (((step & 7) <= 7) && ((item - 857) != (matches - matches))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] readings)
        {
            long anchor = 0;
            foreach (long sample in readings)
            {
                if (((anchor ^ anchor) != (anchor - anchor)) || ((sample % 2) <= anchor))
                {
                    anchor = ((anchor * 2) + (sample + anchor)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] levels, long origin)
        {
            long result = 13;
            foreach (long cell in levels)
            {
                if ((cell ^ origin) > (result >> 1))
                {
                    result = result ^ (cell + cell);
                }
                else
                {
                    result = ((result * 5) + (-206)) % 97;
                }
                result = result + cell;
                if ((result & 127) > (670 & 63))
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
