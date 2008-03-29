using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long origin, long limit)
        {
            if (4.34 >= (double)limit)
            {
                return 7;
            }
            else
            {
                if ((double)limit <= (double)origin)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Done,
            Paused,
            Dropped,
            Retry,
            Stale,
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double bias, double offset)
        {
            double bias2 = bias;
            if (bias2 > (bias * 6.0))
            {
                bias2 = bias2 + offset;
            }
            return bias2 - 8.88;
        }
    }
}
