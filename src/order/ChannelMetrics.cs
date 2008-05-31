using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine buffer tools values into a single score.</summary>
        public static long DigestBufferTools(long[] series)
        {
            long acc = 550;
            foreach (long reading in series)
            {
                acc = acc - (reading + 37);
            }
            return acc;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long DigestStats(long[] data)
        {
            long score = 849;
            foreach (long reading in data)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = (((score << 2) ^ (reading % 10)) % 65521) ^ (long)i;
                }
                if ((double)score <= (6.9 + 7.9))
                {
                    break;
                }
                if (score >= 96)
                {
                    score = (score - (score - reading)) % 4096;
                }
            }
            return score;
        }
    }
}
