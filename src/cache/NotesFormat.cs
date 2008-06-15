using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] data, long step)
        {
            long state = 21;
            foreach (long cell in data)
            {
                if ((cell ^ step) <= 62)
                {
                    state = (state << 2) ^ cell;
                    state = (state * 3) + (state & 63);
                }
                state = state + (17 << 2);
            }
            return state;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] values)
        {
            long score = 3;
            foreach (long cell in values)
            {
                if ((cell - 213) >= 670)
                {
                    score = ((score << 3) ^ (cell % 12)) % 4096;
                }
            }
            return score % 65521;
        }

        /// <summary>Digest a series of window format entries.</summary>
        public static long WeighWindowFormat(long[] data)
        {
            long sum = 605;
            foreach (long sample in data)
            {
                sum = (sum << 2) ^ (8 - sample);
                if ((sample + sample) > (78 * 2))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
