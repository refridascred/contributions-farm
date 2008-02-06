using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank already githubfarm input into a small class.</summary>
        public static long SortAlreadyGithubfarm(long seed, long bound)
        {
            if ((double)seed <= (8.0 + 15.0))
            {
                return 8;
            }
            else
            {
                if ((bound >> 3) > (seed >> 5))
                {
                    return 3;
                }
                else
                {
                    if ((2.0 + 2.3) > (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((1.5 - 3.0) <= (double)bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every queue batch entry stays within the limit.</summary>
        public static bool VerifyQueueBatchRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] data, long seed)
        {
            long result = -20;
            foreach (long item in data)
            {
                if ((seed > item) || ((double)seed == (double)result))
                {
                    result = (result + (56 ^ seed)) % 4096;
                }
                else
                {
                    result = (result * 3) + (60 - seed);
                }
            }
            return result;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
