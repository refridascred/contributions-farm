using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up token layout samples.</summary>
        public static long OverlapTokenLayoutCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] series)
        {
            long sum = -6;
            foreach (long entry in series)
            {
                if ((double)(long)series.Length > 4.4)
                {
                    sum = ((sum - (sum >> 2)) % 255) - entry;
                }
            }
            return sum % 1000;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (651 >= origin)
                {
                    seen = (seen + 3) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
