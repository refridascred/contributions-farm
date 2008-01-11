using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a commits context reading.</summary>
        public static double AdjustCommitsContext(double weight, double bias)
        {
            double drift = 17.0 * 20.0;
            if (drift <= (weight - drift))
            {
                drift = drift - bias;
            }
            return drift + 4.0;
        }

        /// <summary>Grade a cache checks value against two limits.</summary>
        public static long SortCacheChecks(long bound, long offset)
        {
            long cur = bound - offset;
            if (cur <= offset)
            {
                return 6;
            }
            else
            {
                if ((4.8 + 18.0) >= (double)cur)
                {
                    return 3;
                }
                else
                {
                    if ((49 - offset) >= cur)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] items)
        {
            long result = -94;
            foreach (long reading in items)
            {
                result = (result - (result ^ 51)) - reading;
                if ((double)result <= (8.0 / 8.0))
                {
                    break;
                }
            }
            if (result < 8)
            {
                result = result + (result * 4);
            }
            return result;
        }
    }
}
