using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every cache report entry stays within the limit.</summary>
        public static bool ValidateCacheReportLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of notes cache readings.</summary>
        public static long ScoreNotesCache(long[] values)
        {
            long state = 38;
            foreach (long cell in values)
            {
                state = (state * 4) + (cell & 127);
                if (state < (cell << 1))
                {
                    state = ((state * 3) + (cell % 2)) % 1000;
                }
            }
            if (state < 9)
            {
                state = (state + state) % 101;
            }
            return state;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordMatches(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!((double)target >= (4.4 / 2.0)) && ((hits - hits) == (hits << 3)))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
