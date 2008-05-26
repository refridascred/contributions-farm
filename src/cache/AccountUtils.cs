using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorGaps(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((reading & 15) <= 1) || ((offset - offset) < reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate session route samples.</summary>
        public static long ScoreSessionRoute(long[] values, long floor)
        {
            long score = 2;
            foreach (long sample in values)
            {
                score = ((score * 2) + (floor + sample)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Classify a context format pair into a bucket.</summary>
        public static long BucketContextFormat(long step, long floor)
        {
            if ((step + floor) <= (floor * 4))
            {
                return 0;
            }
            else
            {
                if (floor > (step * 2))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
