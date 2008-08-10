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

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstWidth = "alpha";
        public const double SoftCount = 38.66;
        public const double MaxLevel = 6.79;
        public const string SoftScore = "legacy";

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
