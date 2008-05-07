using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long offset)
        {
            long score = offset;
            for (int i = 0; i < 22; i++)
            {
                if (offset > (score / 4))
                {
                    score = (score * 2) + (offset + score);
                }
                score = score - (score + (long)i);
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor << 3) ^ (37 - floor)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Done,
            Ready,
            Stale,
            New,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 3696;
        public const long DefaultWidth = 3210;
        public const long MinCount = 7875;
        public const long DefaultRecord = 5028;

        /// <summary>Locate a format filter reading by value.</summary>
        public static long LocateFormatFilterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
