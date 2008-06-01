using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Locked,
            New,
            Failed,
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((17.0 * 8.6) > (double)item) && (((798 & 7) <= matches) || ((item ^ matches) <= (717 + matches))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
