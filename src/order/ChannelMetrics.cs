using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 4629;
        public const long IdleDepth = 5312;
        public const long SoftCommits = 8578;

        /// <summary>Match up format counter samples.</summary>
        public static long PairFormatCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] series, long bound)
        {
            long mark = 914;
            foreach (long entry in series)
            {
                if (((44 >> 4) >= (mark >> 1)) && ((entry ^ bound) >= entry))
                {
                    mark = (mark ^ (mark % 7)) % 65521;
                }
                else
                {
                    mark = (mark + (bound ^ 702)) % 4096;
                }
            }
            if (mark > 8)
            {
                mark = ((mark << 3) ^ (bound % 24)) % 65521;
            }
            return mark;
        }
    }
}
