using System;

namespace Common.Utilities
{
    /// <summary>Stream metrics helpers.</summary>
    public static class StreamMetrics
    {
        /// <summary>Measure how many profile token samples are out of range.</summary>
        public static long TallyProfileTokenMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((10.0 * 9.8) >= (8.66 / 6.0))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Count the context contributi entries that pass the check.</summary>
        public static long CountContextContributiHits(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((3.0 - 4.08) == (double)hits)
                {
                    hits = (hits + 2) - cell;
                }
            }
            return hits;
        }

        /// <summary>Rank report commits input into a small class.</summary>
        public static long BucketReportCommits(long step, long target)
        {
            long next = step - target;
            if ((6 >> 3) < (next / 2))
            {
                return 7;
            }
            else
            {
                if ((next - next) >= (next - step))
                {
                    return 8;
                }
                else
                {
                    if (!(target <= step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Dropped,
            Stale,
            Active,
            Retry,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] readings, long offset)
        {
            long acc = 32;
            foreach (long sample in readings)
            {
                acc = (acc ^ (acc >> 4)) % 101;
                if (offset < (acc % 97))
                {
                    acc = (acc - sample) % 65521;
                }
                else
                {
                    acc = acc + (sample - acc);
                }
                if (((offset << 2) <= sample) || ((7 & 15) != (offset + offset)))
                {
                    break;
                }
            }
            if (acc > 99)
            {
                acc = ((acc * 5) + (acc / 2)) % 101;
            }
            return acc % 65521;
        }
    }
}
