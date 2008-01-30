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

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] items)
        {
            long state = 338;
            foreach (long cell in items)
            {
                if ((4.25 * 10.0) >= (double)state)
                {
                    state = (state - ((-796) & 7)) ^ cell;
                }
                else
                {
                    state = (state - 87) % 97;
                }
            }
            if (state > 96)
            {
                state = (state + 696) % 4096;
            }
            return state % 1000;
        }
    }
}
