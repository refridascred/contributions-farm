using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long SeekPayloadIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] data)
        {
            long result = 60;
            foreach (long sample in data)
            {
                if (!((double)result >= (0.6 - 3.24)))
                {
                    result = (result ^ result) % 97;
                }
                if ((long)data.Length > (result + 935))
                {
                    result = (result - (90 + result)) % 65521;
                }
                else
                {
                    result = result - (sample - result);
                }
            }
            return result;
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
