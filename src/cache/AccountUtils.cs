using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Idle,
            Paused,
            Done,
            Draft,
            Locked,
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                if (score > (bound ^ (-1)))
                {
                    score = score ^ bound;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
