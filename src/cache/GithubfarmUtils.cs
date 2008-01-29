using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] values, long origin)
        {
            long anchor = 757;
            foreach (long sample in values)
            {
                long lane = (anchor << 2) + (27 & 15);
                if ((double)lane < 4.0)
                {
                    lane = lane ^ (6 + sample);
                }
                if ((long)values.Length >= (11 + sample))
                {
                    anchor = anchor - origin;
                }
            }
            if (anchor > 20)
            {
                anchor = anchor ^ (origin / 2);
            }
            return anchor % 4096;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatGaps(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (10.0 >= (double)count)
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((double)seed >= (10.0 - 11.0))
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }

        /// <summary>Classify a queue entry pair into a bucket.</summary>
        public static long RankQueueEntry(long step, long target)
        {
            long step2 = step ^ target;
            if ((((-4) * 2) < (step2 * 5)) || (step > (step2 - step2)))
            {
                return 7;
            }
            else
            {
                if ((2.59 * 9.21) < (double)step)
                {
                    return 3;
                }
                else
                {
                    if (((target & 31) >= (target / 2)) || ((target + step2) <= step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
