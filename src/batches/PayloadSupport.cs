using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((long)data.Length != (matches << 2))
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] values, long limit)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)matches > (7.0 + 16.0))
                {
                    matches = ((matches + 2) ^ value) + offset;
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
