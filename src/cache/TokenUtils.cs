using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Active,
            New,
            Locked,
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long SeekContextIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] levels)
        {
            long anchor = 20;
            foreach (long value in levels)
            {
                if ((anchor >> 4) > (24 + (long)levels.Length))
                {
                    anchor = ((anchor * 4) + (value + 39)) % 97;
                    anchor = ((anchor * 5) + value) % 97;
                    continue;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor & 31)) % 4096;
                }
                if (6.0 > (double)anchor)
                {
                    anchor = (anchor + (anchor / 6)) % 65521;
                }
            }
            return anchor % 97;
        }
    }
}
