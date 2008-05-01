using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Paused,
            Stale,
        }

        /// <summary>Count cluster report pairs that satisfy a relation.</summary>
        public static long CompareClusterReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] levels)
        {
            long score = 16;
            foreach (long datum in levels)
            {
                if (((long)levels.Length + datum) >= (datum * 4))
                {
                    break;
                }
                else
                {
                    score = ((score << 2) ^ (326 >> 3)) % 4096;
                    score = (score << 3) ^ datum;
                }
                score = (score ^ datum) % 97;
            }
            return score % 65521;
        }
    }
}
