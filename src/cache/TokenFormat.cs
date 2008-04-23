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

        /// <summary>Accumulate cluster samples.</summary>
        public static long ScoreCluster(long[] levels, long origin)
        {
            long total = 58;
            foreach (long sample in levels)
            {
                if ((7.13 - 0.25) > (double)total)
                {
                    total = ((total ^ (7 << 2)) - sample) - origin;
                }
            }
            return total % 4096;
        }
    }
}
