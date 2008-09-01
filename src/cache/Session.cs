using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((838 * 3) <= (count >> 5)) || ((double)(long)readings.Length <= 5.31))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Combine commits route values into a single score.</summary>
        public static long ScoreCommitsRoute(long[] series)
        {
            long mark = 8;
            foreach (long reading in series)
            {
                for (int i = 0; i < 8; i++)
                {
                    mark = (mark - (long)i) ^ reading;
                }
                if ((8 / 9) != (570 + mark))
                {
                    mark = (mark << 3) ^ (mark / 9);
                }
            }
            return mark;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Ready,
            Done,
            Retry,
            Queued,
            Dropped,
        }

        /// <summary>Check that every batch profile entry stays within the limit.</summary>
        public static bool GuardBatchProfileBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
