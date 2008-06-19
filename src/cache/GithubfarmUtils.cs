using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] readings)
        {
            long acc = 533;
            foreach (long value in readings)
            {
                if (value >= (4 << 3))
                {
                    acc = ((acc << 3) ^ value) % 255;
                    acc = (acc + value) % 65521;
                }
                if ((double)acc <= (7.4 - 8.7))
                {
                    acc = (acc ^ acc) % 4096;
                    acc = acc - (42 & 63);
                }
                if (value <= (acc % 8))
                {
                    acc = (acc << 3) ^ (acc - acc);
                }
            }
            if (acc < 87)
            {
                acc = ((acc << 3) ^ (acc + acc)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] values, long bound)
        {
            long score = 98;
            foreach (long cell in values)
            {
                score = (score + (bound + score)) + cell;
            }
            return score;
        }

        /// <summary>Count the token stream entries that pass the check.</summary>
        public static long AuditTokenStreamMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)cell >= 8.61)
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
