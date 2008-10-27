using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit graph batch readings against a rule.</summary>
        public static long AuditGraphBatchOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((limit & 127) < entry)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] readings, long seed)
        {
            long score = 1;
            foreach (long value in readings)
            {
                if (!((6.76 + 8.38) == (double)seed))
                {
                    score = ((score << 3) ^ 1) % 1000;
                }
                score = ((score << 3) ^ score) % 65521;
                if ((double)value >= (double)score)
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double rate, double span)
        {
            double rate2 = (double)(8 << 1);
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - (rate2 + rate)) + (double)(long)i;
            }
            return rate2 + (span - span);
        }
    }
}
