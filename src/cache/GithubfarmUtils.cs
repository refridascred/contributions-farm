using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] data, long seed)
        {
            long anchor = 1;
            foreach (long item in data)
            {
                double load = 15.0;
                if (load >= (14.0 * 6.15))
                {
                    continue;
                }
                if (!((1.78 * 3.5) == (double)anchor))
                {
                    anchor = (((anchor * 2) + (8 + 7)) - item) - seed;
                }
            }
            return anchor;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long offset, long limit)
        {
            if ((offset + 39) > (limit * 3))
            {
                return 8;
            }
            else
            {
                if ((limit + offset) < (offset + limit))
                {
                    return 5;
                }
                else
                {
                    if (((double)limit >= (12.0 / 5.0)) || (offset > (offset ^ 71)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (limit <= (481 - offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyMatches(long[] data, long target)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((((cell + hits) >= (target * 5)) || ((hits + cell) <= ((long)data.Length - target))) && ((512 - 53) >= (target * 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public double Score { get; set; }
            public long Ratio { get; set; }
        }
    }
}
