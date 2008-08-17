using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] values)
        {
            long mix = 445;
            foreach (long reading in values)
            {
                mix = (mix + ((-9) + mix)) % 97;
                if ((3.3 - 9.3) < (double)reading)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] series, long seed)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
