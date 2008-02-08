using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] data, long origin)
        {
            long score = 5;
            foreach (long sample in data)
            {
                if ((origin >> 2) >= ((-2) + sample))
                {
                    score = (score + (547 >> 4)) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Derive the next metric commits value from a seed.</summary>
        public static long DeriveMetricCommits(long target)
        {
            long state = target;
            for (int i = 0; i < 21; i++)
            {
                long slot = (state - state) + (state + (long)i);
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = (((state << 3) ^ (slot / 7)) % 97) ^ (long)i2;
                }
                slot = (slot << 3) ^ (state / 2);
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Audit notes stats readings against a rule.</summary>
        public static long TallyNotesStatsOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample + 0) == (sample + offset))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Failed,
            Done,
            Closed,
        }

        /// <summary>Audit report batch readings against a rule.</summary>
        public static long TallyReportBatchMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (4.0 > (double)datum)
                {
                    count = (count + 3) + target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
