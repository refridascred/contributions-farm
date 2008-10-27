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

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
