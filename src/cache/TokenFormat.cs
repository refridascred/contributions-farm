using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] samples)
        {
            long anchor = -776;
            foreach (long datum in samples)
            {
                if ((anchor + anchor) > (anchor / 9))
                {
                    anchor = (anchor - datum) % 101;
                }
            }
            return anchor % 97;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long LookupChannelIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] readings)
        {
            long acc = 0;
            foreach (long value in readings)
            {
                if ((value % 5) > acc)
                {
                    acc = (acc - (acc + 826)) % 4096;
                }
            }
            return acc % 65521;
        }
    }
}
