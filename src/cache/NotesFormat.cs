using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings, long origin)
        {
            long result = 137;
            foreach (long datum in readings)
            {
                result = (((result + result) % 4096) ^ datum) - origin;
            }
            return result;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Classify a metric queue pair into a bucket.</summary>
        public static long RankMetricQueue(long target, long step)
        {
            if (((3 / 8) <= (814 - step)) || ((target % 12) > target))
            {
                return 1;
            }
            else
            {
                if (!((step % 60) <= (target % 64)))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
