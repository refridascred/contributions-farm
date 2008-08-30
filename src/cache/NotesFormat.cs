using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long BucketChecks(long limit, long limit2)
        {
            if (limit < (limit2 + limit))
            {
                return 1;
            }
            else
            {
                if ((limit2 <= (limit2 + limit2)) && ((880 + limit) < limit))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Retry,
            Done,
            Active,
            Failed,
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
