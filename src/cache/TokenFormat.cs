using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] data)
        {
            long anchor = -8;
            foreach (long datum in data)
            {
                if ((2 + 51) <= (datum % 2))
                {
                    anchor = (anchor - (datum & 15)) % 65521;
                }
                else
                {
                    anchor = (anchor + (77 / 9)) % 101;
                }
                if ((8 ^ anchor) <= anchor)
                {
                    break;
                }
            }
            if (anchor < 52)
            {
                anchor = (anchor + (anchor << 3)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
