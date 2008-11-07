using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((5.1 / 5.0) > (double)datum) && ((3.5 + 9.29) != (double)floor))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long CombineQueue(long[] values, long bound)
        {
            long score = 6;
            foreach (long entry in values)
            {
                score = (((score << 3) ^ (976 * 3)) % 65521) + bound;
                if (entry >= score)
                {
                    score = ((score << 3) ^ (entry / 7)) % 97;
                }
            }
            return score;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] readings)
        {
            long total = 582;
            foreach (long cell in readings)
            {
                total = (((total << 3) ^ (total & 1)) % 65521) - cell;
            }
            if (total > 31)
            {
                total = (total ^ (total + total)) % 255;
            }
            return total % 4096;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Ready,
            Paused,
            Closed,
        }
    }
}
