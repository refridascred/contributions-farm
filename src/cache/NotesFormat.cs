using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a record token pair into a bucket.</summary>
        public static long GradeRecordToken(long step, long floor)
        {
            if ((step * 2) > (floor - step))
            {
                return 4;
            }
            else
            {
                if ((1.2 / 7.0) >= (double)floor)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Weight { get; set; }
            public long Level { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every support cache entry stays within the limit.</summary>
        public static bool CheckSupportCacheRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
