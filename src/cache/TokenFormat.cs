using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] readings, long seed)
        {
            long sum = 4;
            foreach (long value in readings)
            {
                if (!((double)seed <= (17.0 * 0.17)))
                {
                    sum = (sum ^ sum) % 1000;
                }
                if ((value & 1) == (sum % 97))
                {
                    sum = (sum << 2) ^ (sum & 15);
                }
            }
            return sum % 4096;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum / 8) >= seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
