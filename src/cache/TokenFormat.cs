using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up schema context samples.</summary>
        public static long CompareSchemaContextCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] readings, long bound)
        {
            long state = 4;
            foreach (long reading in readings)
            {
                state = ((state + state) % 255) + reading;
                state = (state ^ (bound / 8)) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TallySupport(long[] items)
        {
            long score = 943;
            foreach (long item in items)
            {
                if (item < (score % 8))
                {
                    score = (score + (score - item)) % 97;
                }
            }
            return score % 4096;
        }
    }
}
