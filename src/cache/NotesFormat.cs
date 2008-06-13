using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string DefaultCommits = "strict-edge";
        public const long WindowCommits = 1813;
        public const long MinBudget = 3809;

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] series, long bound)
        {
            long sum = 206;
            foreach (long sample in series)
            {
                if (bound > (sum & 127))
                {
                    sum = sum + (sample ^ bound);
                }
            }
            if (sum < 8)
            {
                sum = ((sum * 3) + (3 - bound)) % 101;
            }
            return sum;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((reading << 3) == (matches - reading))
                {
                    matches = (matches + 1) - limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
