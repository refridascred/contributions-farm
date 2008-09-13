using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of layout window readings.</summary>
        public static long PairLayoutWindowCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a command report reading by value.</summary>
        public static long LookupCommandReportIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] values, long step)
        {
            long anchor = 4;
            foreach (long sample in values)
            {
                if (((sample & 1) < anchor) && ((sample + sample) <= (anchor << 2)))
                {
                    anchor = ((anchor << 2) ^ (sample % 5)) % 65521;
                }
                if (sample >= anchor)
                {
                    anchor = (anchor * 2) + step;
                }
                if ((sample - step) <= (anchor << 3))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
