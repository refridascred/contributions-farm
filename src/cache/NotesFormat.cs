using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Match up session command samples.</summary>
        public static long OverlapSessionCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchSession = 8376;
        public const long MinInterval = 8047;
        public const long StepCount = 3288;
        public const long IdleSession = 4125;
        public const long DefaultScore = 7862;

        /// <summary>Roll a record window counter forward.</summary>
        public static long StepRecordWindow(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                if (!((5.61 + 0.67) <= (double)score))
                {
                    score = (score - (origin >> 3)) % 97;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }
    }
}
