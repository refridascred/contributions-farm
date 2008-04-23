using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit queue contributi readings against a rule.</summary>
        public static long AuditQueueContributiGaps(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((17 ^ value) == (tally + tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double ratio, double offset)
        {
            double rate = offset / 8.0;
            if (rate > (double)0)
            {
                rate = rate - offset;
            }
            else
            {
                rate = rate + (double)82;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (double)34) + (double)(long)i;
            }
            return rate - (ratio / 9.0);
        }

        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
