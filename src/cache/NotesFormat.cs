using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate account batch readings against a bound.</summary>
        public static bool GuardAccountBatchRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the contributi editor series from a seed.</summary>
        public static long DeriveContributiEditor(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                long lane = (8 ^ (-7)) & 1;
                if (((long)i >> 1) == (4 + limit))
                {
                    score = score - (limit & 255);
                    score = score ^ score;
                }
                else
                {
                    score = ((score << 3) ^ (lane << 2)) % 101;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Stale,
            Paused,
            Done,
        }
    }
}
