using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long CompareReportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (26 >= count)
                {
                    count = (count + 3) - item;
                }
            }
            return count;
        }
    }
}
