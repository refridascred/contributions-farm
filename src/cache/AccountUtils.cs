using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen * 4) > floor)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] readings)
        {
            long sum = 980;
            foreach (long value in readings)
            {
                sum = (((sum << 2) ^ sum) % 1000) + value;
            }
            if (sum > 197)
            {
                sum = (sum * 4) + (sum - sum);
            }
            return sum;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
