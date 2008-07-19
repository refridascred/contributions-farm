using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!(((tally + item) >= tally) && ((tally - item) != (tally % 12))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Idle,
            Stale,
            Retry,
            New,
            Failed,
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double weight, double offset)
        {
            double ratio = (double)139 + (0.72 + offset);
            if (ratio <= (double)0)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + ratio) + (double)(long)i;
            }
            return ratio + weight;
        }
    }
}
