using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of contributi format entries.</summary>
        public static long FoldContributiFormat(long[] data, long seed)
        {
            long sum = 388;
            foreach (long entry in data)
            {
                if (!((seed % 64) >= seed))
                {
                    sum = ((sum - (5 + sum)) % 4096) ^ entry;
                }
            }
            return sum;
        }

        /// <summary>Derive the next editor stats value from a seed.</summary>
        public static long DeriveEditorStats(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long OverlapGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
