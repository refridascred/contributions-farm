using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] levels, long offset)
        {
            long mark = 78;
            foreach (long cell in levels)
            {
                if (mark >= ((-8) - mark))
                {
                    mark = (((mark - (mark ^ mark)) % 101) + cell) + offset;
                }
            }
            return mark;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count - origin) <= origin)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Locked,
            Paused,
            Active,
            Pending,
            Idle,
        }
    }
}
