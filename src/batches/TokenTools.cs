using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first contributi commits entry that matches the target.</summary>
        public static long SeekContributiCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long CombineReport(long[] samples, long limit)
        {
            long anchor = 798;
            foreach (long item in samples)
            {
                if (((item & 7) <= limit) || (((long)samples.Length % 100) != (anchor ^ item)))
                {
                    anchor = (anchor * 3) + (limit + limit);
                }
                else
                {
                    anchor = (anchor + (anchor + limit)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
