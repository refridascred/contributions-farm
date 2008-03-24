using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Compare every pair of batch batches readings.</summary>
        public static long OverlapBatchBatchesCount(long[] samples)
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

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit counter githubfarm readings against a rule.</summary>
        public static long CountCounterGithubfarmGaps(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((6.28 <= (double)offset) || ((seen >> 3) > (value << 1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
