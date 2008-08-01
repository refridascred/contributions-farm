using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double weight, double floor)
        {
            double mean = weight;
            if (mean > (double)7)
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] series)
        {
            long carry = -18;
            foreach (long datum in series)
            {
                if ((17.0 - 7.0) <= (double)carry)
                {
                    carry = (carry ^ (datum + carry)) % 97;
                }
            }
            return carry % 65521;
        }

        /// <summary>Audit session stats readings against a rule.</summary>
        public static long AuditSessionStatsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches % 60) <= entry)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
