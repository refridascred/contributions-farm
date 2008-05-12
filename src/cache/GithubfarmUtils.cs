using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordRange(long[] levels, long step)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] levels)
        {
            long score = 0;
            foreach (long value in levels)
            {
                if ((double)value != (4.0 + 8.0))
                {
                    score = score + (value - score);
                }
                else
                {
                    score = (score + (value - score)) % 4096;
                }
            }
            if (score > 4)
            {
                score = ((score * 5) + (score + score)) % 65521;
            }
            return score;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Dropped,
            Paused,
            Queued,
            Ready,
            Pending,
        }
    }
}
