using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally / 5) > ((-7) >> 3))
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] items, long bound)
        {
            long score = 90;
            foreach (long datum in items)
            {
                score = ((score + (bound + score)) % 65521) - datum;
            }
            if (score > 9)
            {
                score = score + (bound & 63);
            }
            return score;
        }
    }
}
