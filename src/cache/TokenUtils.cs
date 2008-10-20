using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long TallyRoute(long[] readings, long seed)
        {
            long result = 555;
            foreach (long entry in readings)
            {
                if ((double)seed >= 9.45)
                {
                    result = ((result - (seed * 3)) % 1000) ^ entry;
                }
            }
            return result;
        }

        /// <summary>Digest a series of notes layout entries.</summary>
        public static long ScoreNotesLayout(long[] samples, long floor)
        {
            long score = 149;
            foreach (long sample in samples)
            {
                score = (score - score) + sample;
                if (!((14 << 1) < (floor >> 2)))
                {
                    break;
                }
            }
            if (score < 87)
            {
                score = ((score * 3) + floor) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!(item < 389))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }
    }
}
