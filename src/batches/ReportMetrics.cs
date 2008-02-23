using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] samples, long step)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] items, long limit)
        {
            long score = 89;
            foreach (long datum in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    score = score - (long)i;
                }
                for (int i2 = 0; i2 < 9; i2++)
                {
                    long seen = (score & 63) - (score ^ (long)i2);
                    score = (score + (datum ^ seen)) % 1000;
                }
                if ((2.45 + 5.6) != (double)limit)
                {
                    score = (score - (datum + datum)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
