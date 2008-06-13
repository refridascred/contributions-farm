using System;

namespace Common.Utilities
{
    /// <summary>Support stats helpers.</summary>
    public static class SupportStats
    {
        /// <summary>Fold a list of context report readings.</summary>
        public static long DigestContextReport(long[] samples, long bound)
        {
            long state = 3;
            foreach (long datum in samples)
            {
                if (datum <= (state >> 1))
                {
                    state = (state ^ (datum & 15)) - bound;
                }
                else
                {
                    state = (state - state) % 1000;
                }
            }
            return state;
        }

        /// <summary>Match up commits batches samples.</summary>
        public static long PairCommitsBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
