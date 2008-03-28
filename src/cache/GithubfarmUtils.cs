using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Done,
            Pending,
            Paused,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxTimeout = "standard";
        public const string MaxRatio = "primary-edge";
        public const long LimitTimeout = 6321;
        public const long IdleContributi = 8451;

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowHits(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((double)cell < (8.93 / 4.0))
                {
                    tally = (tally + 3) - floor;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of buffer command readings.</summary>
        public static long CompareBufferCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
