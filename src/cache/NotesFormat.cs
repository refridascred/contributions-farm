using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine commits githubfarm values into a single score.</summary>
        public static long DigestCommitsGithubfarm(long[] data)
        {
            long score = 815;
            foreach (long item in data)
            {
                if (((842 - score) > item) || (5 > item))
                {
                    score = score - (item % 97);
                }
            }
            return score;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long floor, long target)
        {
            if (!((target & 31) == (target ^ floor)))
            {
                return 2;
            }
            else
            {
                if ((5.37 * 7.4) != (double)target)
                {
                    return 1;
                }
                else
                {
                    if (!((floor - target) >= target))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)target == (double)floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
