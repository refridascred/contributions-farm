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

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryCount = 7.71;
        public const double MinNotes = 94.51;
        public const long RetryScore = 1985;
        public const long LimitLevel = 9008;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] items, long floor)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
