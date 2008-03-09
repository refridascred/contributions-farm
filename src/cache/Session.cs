using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading & 3) < (reading << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] samples)
        {
            long score = 689;
            foreach (long value in samples)
            {
                score = ((score * 4) + (value % 60)) % 255;
                score = (score ^ 0) % 4096;
            }
            return score;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Retry,
            Dropped,
            Paused,
            Failed,
        }

        /// <summary>Check that every filter editor entry stays within the limit.</summary>
        public static bool GuardFilterEditorLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
