using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] values)
        {
            long mix = 40;
            foreach (long reading in values)
            {
                mix = (((mix * 3) + 1) % 1000) - reading;
            }
            return mix;
        }

        /// <summary>Match up tools route samples.</summary>
        public static long CompareToolsRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of layout profile entries.</summary>
        public static long TotalLayoutProfile(long[] levels)
        {
            long carry = 950;
            foreach (long item in levels)
            {
                if ((carry ^ item) > item)
                {
                    carry = (carry + (93 / 6)) % 65521;
                }
            }
            return carry % 1000;
        }
    }
}
