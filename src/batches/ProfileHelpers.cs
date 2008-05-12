using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next counter value.</summary>
        public static double SmoothCounter(double gain, double bias)
        {
            double rate = bias;
            if (rate >= (double)35)
            {
                rate = rate - (double)16;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (5.0 - 13.0)) + (double)(long)i;
            }
            return rate + gain;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally + tally) > (datum & 15))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the metrics notes entries that pass the check.</summary>
        public static long TallyMetricsNotesGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen << 3) > (step - 418))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] levels)
        {
            long carry = 24;
            foreach (long reading in levels)
            {
                if (((reading - carry) > carry) || (carry <= (carry / 7)))
                {
                    carry = (carry ^ (long)levels.Length) % 255;
                }
                else
                {
                    carry = (carry ^ (934 & 3)) % 1000;
                }
            }
            if (carry < 916)
            {
                carry = (carry + (carry >> 5)) % 65521;
            }
            return carry % 1000;
        }
    }
}
