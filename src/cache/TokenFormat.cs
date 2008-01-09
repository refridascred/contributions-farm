using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of window queue entries.</summary>
        public static long TotalWindowQueue(long[] values)
        {
            long anchor = -87;
            foreach (long reading in values)
            {
                anchor = (anchor + reading) % 101;
            }
            return anchor;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseSpan = 1217;
        public const double BatchTools = 69.32;
        public const string MaxTools = "open";
        public const long LimitSpan = 5419;
        public const long BatchCount = 1996;
    }
}
