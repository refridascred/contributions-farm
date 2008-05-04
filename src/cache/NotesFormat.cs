using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every filter channel entry stays within the limit.</summary>
        public static bool CheckFilterChannelBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                if (!(score >= (43 - score)))
                {
                    score = (score + (score / 6)) % 4096;
                    break;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
