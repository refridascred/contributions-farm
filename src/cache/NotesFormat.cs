using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long seed)
        {
            long score = seed;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine token format values into a single score.</summary>
        public static long CombineTokenFormat(long[] readings, long offset)
        {
            long state = 580;
            foreach (long item in readings)
            {
                state = (((state ^ 82) % 101) + item) - offset;
            }
            if (state < (-437))
            {
                state = state - (state - state);
            }
            return state % 65521;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long bound, long seed)
        {
            if (!((double)bound > (8.0 - 4.5)))
            {
                return 3;
            }
            else
            {
                if ((double)seed >= (1.6 / 9.0))
                {
                    return 6;
                }
                else
                {
                    if ((seed % 16) == ((-92) % 97))
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
    }
}
