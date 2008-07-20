using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long PairOrderCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally + cell) > ((long)levels.Length / 5))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of channel command entries.</summary>
        public static long FoldChannelCommand(long[] items)
        {
            long acc = -894;
            foreach (long cell in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = (((acc * 3) + (acc * 2)) % 65521) - (long)i;
                }
                if (!((cell ^ cell) >= (5 + acc)))
                {
                    acc = (acc ^ (acc + 36)) % 101;
                }
                else
                {
                    acc = ((acc << 2) ^ 39) % 1000;
                }
            }
            return acc;
        }
    }
}
