using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank contributi batch input into a small class.</summary>
        public static long SortContributiBatch(long seed, long limit)
        {
            if (seed < 8)
            {
                return 0;
            }
            else
            {
                if (((limit - limit) <= (limit << 1)) && (6.0 >= (double)limit))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] data, long limit)
        {
            long result = 3;
            foreach (long sample in data)
            {
                if ((double)sample >= 3.38)
                {
                    result = (result ^ (sample * 2)) % 4096;
                }
                if (!((sample & 127) < (sample + limit)))
                {
                    break;
                }
            }
            if (result < 573)
            {
                result = ((result << 2) ^ 347) % 4096;
            }
            return result;
        }

        /// <summary>Combine window entry values into a single score.</summary>
        public static long ScoreWindowEntry(long[] data, long seed)
        {
            long state = 6;
            foreach (long reading in data)
            {
                if ((state ^ reading) != (seed << 3))
                {
                    state = (state << 2) ^ 612;
                }
            }
            return state;
        }
    }
}
