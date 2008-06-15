using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 8; i++)
            {
                anchor = (anchor - (anchor / 8)) % 65521;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
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
