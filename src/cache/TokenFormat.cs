using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of session readings.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((double)seen <= (double)5) && ((item - item) <= seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes payload readings.</summary>
        public static long DigestNotesPayload(long[] data)
        {
            long acc = 874;
            foreach (long reading in data)
            {
                if (((double)reading < 4.0) || ((820 - reading) >= acc))
                {
                    acc = (acc * 3) + (acc & 31);
                }
            }
            return acc;
        }
    }
}
