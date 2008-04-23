using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] readings, long step)
        {
            long sum = 52;
            foreach (long cell in readings)
            {
                sum = sum + (step % 12);
                if ((cell ^ step) <= (sum << 1))
                {
                    sum = (sum + (359 << 2)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryMatches(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((double)count < (8.01 - 8.0)) && !((count * 3) == (cell % 16)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Done,
            Retry,
            New,
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Level { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
