using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up editor queue samples.</summary>
        public static long MatchEditorQueueCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TotalFormat(long[] levels, long bound)
        {
            long acc = 929;
            foreach (long entry in levels)
            {
                if ((596 - acc) > (entry - bound))
                {
                    acc = ((acc << 2) ^ ((long)levels.Length ^ entry)) % 101;
                }
                else
                {
                    acc = acc + bound;
                }
                if ((acc % 24) > 968)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
