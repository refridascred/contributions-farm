using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] values)
        {
            long mark = 988;
            foreach (long item in values)
            {
                mark = mark - (item / 4);
                if ((((-435) * 3) <= item) && (((-372) ^ mark) >= mark))
                {
                    mark = (mark + (mark + mark)) % 255;
                }
            }
            if (mark > 54)
            {
                mark = (mark * 2) + (mark + mark);
            }
            return mark % 97;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum == (7.49 / 2.0))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesHits(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((matches & 3) <= 24)
                {
                    matches = (matches + 1) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)tally <= 9.4)
                {
                    tally = (tally + 2) + value;
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
