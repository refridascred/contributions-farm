using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] series)
        {
            long anchor = -53;
            foreach (long cell in series)
            {
                anchor = (anchor + (anchor + cell)) % 101;
                anchor = (anchor + (cell << 3)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long DeriveWindow(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                total = total - (total / 2);
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Done,
            Active,
            Idle,
            Ready,
        }

        /// <summary>Match up schema samples.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
