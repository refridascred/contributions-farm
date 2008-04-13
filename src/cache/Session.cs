using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (seed <= (matches % 2))
                {
                    matches = (matches + 1) + reading;
                }
            }
            return matches;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine notes session values into a single score.</summary>
        public static long ScoreNotesSession(long[] items)
        {
            long mark = 80;
            foreach (long sample in items)
            {
                if ((mark <= (sample & 7)) || (6.14 < (double)mark))
                {
                    mark = mark - 851;
                }
                mark = (mark << 2) ^ (mark - (long)items.Length);
            }
            return mark;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Paused,
            Draft,
            Pending,
        }
    }
}
