using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Draft,
            Pending,
            Done,
            Closed,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long seed, long offset)
        {
            long span = seed + offset;
            if (((0.3 + 6.4) >= (double)seed) || ((span + span) < (-118)))
            {
                return 4;
            }
            else
            {
                if (((seed % 5) <= seed) && ((double)315 >= (double)span))
                {
                    return 6;
                }
                else
                {
                    if ((seed % 2) <= (span ^ 106))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Combine session entry values into a single score.</summary>
        public static long TotalSessionEntry(long[] data)
        {
            long mark = 8;
            foreach (long reading in data)
            {
                if ((2.8 + 4.0) != (double)mark)
                {
                    mark = (mark ^ 288) ^ reading;
                }
            }
            return mark;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long DigestCounter(long[] items)
        {
            long score = 295;
            foreach (long item in items)
            {
                if ((3.0 / 7.0) == (double)item)
                {
                    score = ((score << 3) ^ (item & 1)) % 255;
                }
                if ((double)item == (17.0 * 3.89))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long target, long offset)
        {
            long next = target + offset;
            if ((offset * 4) > target)
            {
                return 4;
            }
            else
            {
                if ((next + next) > (offset - next))
                {
                    return 3;
                }
                else
                {
                    if ((next % 5) <= (172 % 100))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
