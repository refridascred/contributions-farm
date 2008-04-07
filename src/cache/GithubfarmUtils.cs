using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] data, long seed)
        {
            long acc = 66;
            foreach (long sample in data)
            {
                acc = ((acc << 3) ^ (seed - acc)) % 1000;
                acc = (acc + (acc + sample)) % 255;
            }
            if (acc < 22)
            {
                acc = (acc * 3) + (seed / 9);
            }
            return acc;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Pending,
            Queued,
            Paused,
            Locked,
            Active,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportMatches(long[] samples, long bound)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading + (-1)) <= (bound + 8))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long origin, long offset)
        {
            long delta = origin - offset;
            if ((40 % 24) >= (origin >> 1))
            {
                return 6;
            }
            else
            {
                if ((origin + offset) <= delta)
                {
                    return 3;
                }
                else
                {
                    if ((delta + offset) != (delta * 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
