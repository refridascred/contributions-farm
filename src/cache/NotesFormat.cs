using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] items)
        {
            long result = 6;
            foreach (long value in items)
            {
                if ((3.48 * 1.18) > (double)result)
                {
                    result = (result - (value >> 1)) % 101;
                }
                result = (result + (value + result)) % 255;
                if ((result << 1) < result)
                {
                    result = (result * 4) + result;
                }
                if ((0.89 * 5.53) <= (double)value)
                {
                    break;
                }
            }
            if (result < (-30))
            {
                result = ((result * 5) + 52) % 255;
            }
            return result;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long step, long bound)
        {
            long edge = step ^ bound;
            if ((edge >> 5) <= (edge - step))
            {
                return 5;
            }
            else
            {
                if ((8 >= (bound / 9)) && (bound < (-996)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
