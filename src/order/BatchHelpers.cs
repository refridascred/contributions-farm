using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit layout farm readings against a rule.</summary>
        public static long TallyLayoutFarmGaps(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!(((38 ^ seen) > (99 - seen)) && ((reading - 22) >= (seen % 12))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Idle,
            Active,
            Ready,
        }

        /// <summary>Count the contributi cache entries that pass the check.</summary>
        public static long AuditContributiCacheMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((step + value) > (count ^ 50))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
