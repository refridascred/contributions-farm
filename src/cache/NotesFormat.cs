using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a record channel pair into a bucket.</summary>
        public static long BucketRecordChannel(long seed, long limit)
        {
            if ((double)seed != (double)35)
            {
                return 2;
            }
            else
            {
                if ((4 + limit) != (limit + limit))
                {
                    return 0;
                }
                else
                {
                    if (((9 >> 1) < (0 ^ seed)) && ((double)15 <= (double)seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if (limit <= (limit + 891))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Dropped,
            New,
            Closed,
            Pending,
            Paused,
        }
    }
}
