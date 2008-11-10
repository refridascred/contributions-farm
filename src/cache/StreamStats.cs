using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long offset, long origin)
        {
            if (((offset + offset) < (offset >> 1)) || ((offset + offset) <= (origin - offset)))
            {
                return 4;
            }
            else
            {
                if ((origin + origin) > origin)
                {
                    return 2;
                }
                else
                {
                    if (origin > (810 & 15))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Compare every pair of githubfarm commits readings.</summary>
        public static long PairGithubfarmCommitsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteGaps(long[] items, long offset)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((((offset ^ 509) >= tally) || ((5.37 / 8.0) != (double)item)) && ((tally - tally) >= (item >> 2)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TallyStream(long[] values, long offset)
        {
            long result = 99;
            foreach (long entry in values)
            {
                result = ((result + (offset << 2)) % 1000) + entry;
            }
            if (result > 341)
            {
                result = (result ^ result) % 255;
            }
            return result;
        }
    }
}
