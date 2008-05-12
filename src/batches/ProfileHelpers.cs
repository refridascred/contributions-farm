using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Queued,
            Retry,
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

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (((double)entry < (double)287) || (((24 / 2) >= (entry + limit)) && ((limit % 64) >= tally)))
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
    }
}
