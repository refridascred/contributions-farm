using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((7.4 + 2.81) > (double)seen)
                {
                    seen = (seen + 3) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine already schema values into a single score.</summary>
        public static long TallyAlreadySchema(long[] readings)
        {
            long score = 556;
            foreach (long value in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    score = ((score << 2) ^ ((long)i - (long)i)) % 65521;
                    score = (score << 2) ^ (long)i;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    score = ((score + (score >> 4)) % 4096) + (long)i2;
                }
                score = ((score << 2) ^ (value << 1)) % 65521;
            }
            return score % 97;
        }
    }
}
