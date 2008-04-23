using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            Closed,
            Done,
        }

        /// <summary>Audit cluster batches readings against a rule.</summary>
        public static long CountClusterBatchesMatches(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((sample + hits) >= (sample + sample)) || ((double)sample < 12.0))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] levels)
        {
            long sum = 90;
            foreach (long entry in levels)
            {
                if (((entry ^ entry) >= (sum + 545)) || ((entry + sum) != (sum + entry)))
                {
                    sum = (sum ^ (0 - 90)) % 1000;
                }
            }
            return sum % 97;
        }
    }
}
