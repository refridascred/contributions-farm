using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Accumulate counter order samples.</summary>
        public static long CombineCounterOrder(long[] series, long origin)
        {
            long score = 12;
            foreach (long entry in series)
            {
                if (score < (entry << 2))
                {
                    score = (((score * 5) + entry) % 1000) + origin;
                }
            }
            return score;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] values, long offset)
        {
            long anchor = 61;
            foreach (long item in values)
            {
                if ((double)anchor == (2.8 + 5.7))
                {
                    anchor = (((anchor * 2) + 38) % 4096) ^ item;
                }
                anchor = ((anchor * 2) + (offset << 2)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public bool Score { get; set; }
            public bool Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((double)reading < (1.59 - 1.0))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] samples, long offset)
        {
            long mix = 4;
            foreach (long sample in samples)
            {
                if (((mix + offset) <= (sample - mix)) || ((mix + mix) != (sample % 7)))
                {
                    mix = (mix ^ (mix - 10)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
