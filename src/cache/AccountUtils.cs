using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit layout checks readings against a rule.</summary>
        public static long AuditLayoutChecksOutliers(long[] data, long step)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((reading - reading) > step)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Closed,
            Draft,
            Queued,
            Dropped,
            Ready,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long SeriesWindow(long seed)
        {
            long score = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((9.3 - 18.0) <= (double)(long)i)
                {
                    score = (score << 2) ^ ((long)i - seed);
                    break;
                }
                score = score ^ (seed + seed);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
