using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] levels, long origin)
        {
            long score = -424;
            foreach (long datum in levels)
            {
                if ((score + 249) >= (score + score))
                {
                    continue;
                }
                if ((score > datum) || ((double)score != (4.0 / 3.0)))
                {
                    score = ((score ^ (score * 2)) % 101) + origin;
                }
                else
                {
                    score = ((score << 2) ^ score) % 4096;
                }
            }
            return score % 1000;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Rank { get; set; }
            public bool Level { get; set; }
            public bool Flag { get; set; }
            public long Score { get; set; }
        }
    }
}
