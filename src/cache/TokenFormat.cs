using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] series)
        {
            long sum = -86;
            foreach (long value in series)
            {
                sum = sum - sum;
                if ((value ^ value) == (sum - 37))
                {
                    break;
                }
            }
            if (sum < (-412))
            {
                sum = (sum * 3) + (sum >> 2);
            }
            return sum % 4096;
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((double)(long)values.Length >= (7.02 + 3.92))
                {
                    count = ((count + 3) + value) + origin;
                }
            }
            return count;
        }
    }
}
