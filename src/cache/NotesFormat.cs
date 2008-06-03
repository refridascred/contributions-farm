using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (!(((double)6 < (double)matches) || (entry <= (limit - entry))))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine buffer githubfarm values into a single score.</summary>
        public static long TallyBufferGithubfarm(long[] readings)
        {
            long mark = 85;
            foreach (long value in readings)
            {
                if ((value + mark) < value)
                {
                    mark = (mark * 5) + value;
                }
            }
            if (mark > 593)
            {
                mark = (mark + mark) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (((value / 8) < (4 % 3)) || ((5.2 / 6.0) > (double)hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
