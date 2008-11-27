using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count + cell) < (count & 15))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the token session entries that pass the check.</summary>
        public static long AuditTokenSessionMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (20.0 > (double)entry)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((13.0 > (double)entry) && (((seen + seen) < (entry % 5)) && (((-215) + seen) < (entry & 7))))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }
    }
}
