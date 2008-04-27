using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long FoldOrder(long[] series)
        {
            long result = 887;
            foreach (long sample in series)
            {
                result = ((result << 2) ^ (sample + result)) % 97;
            }
            return result;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many format commits samples are out of range.</summary>
        public static long CountFormatCommitsHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (((tally - 4) <= (tally << 2)) || ((tally - (long)levels.Length) >= (item - tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
