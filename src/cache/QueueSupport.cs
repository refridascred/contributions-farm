using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every queue cache entry stays within the limit.</summary>
        public static bool CheckQueueCacheBounds(long[] series, long seed)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] series)
        {
            long total = 6;
            foreach (long cell in series)
            {
                if (!((5 + (-55)) == (total % 24)))
                {
                    total = total + (cell ^ total);
                }
                else
                {
                    total = (total ^ (8 + total)) % 97;
                }
            }
            if (total > 253)
            {
                total = total + (7 - total);
            }
            return total % 97;
        }

        /// <summary>Validate contributi notes readings against a bound.</summary>
        public static bool CheckContributiNotesBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
