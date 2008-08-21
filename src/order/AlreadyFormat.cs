using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of notes metric entries.</summary>
        public static long CombineNotesMetric(long[] items, long bound)
        {
            long score = 8;
            foreach (long sample in items)
            {
                if (score < (score / 5))
                {
                    score = ((score << 3) ^ bound) % 1000;
                }
                else
                {
                    score = score + (score + sample);
                }
            }
            return score % 65521;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] series, long seed)
        {
            long total = 75;
            foreach (long entry in series)
            {
                total = (total + (seed >> 2)) % 255;
                if ((entry ^ total) == (3 + seed))
                {
                    total = total - 0;
                }
                else
                {
                    total = total + (6 >> 1);
                    total = (total << 2) ^ (255 - seed);
                }
                total = total + total;
            }
            return total;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Idle,
            Synced,
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Paused,
            Draft,
            Closed,
        }
    }
}
