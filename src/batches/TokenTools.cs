using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a entry batch value against two limits.</summary>
        public static long SortEntryBatch(long target, long offset)
        {
            if ((offset / 6) < offset)
            {
                return 5;
            }
            else
            {
                if ((target ^ target) == (target >> 5))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandHits(long[] series, long bound)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((bound * 5) >= count)
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Audit schema payload readings against a rule.</summary>
        public static long AuditSchemaPayloadOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((15.0 + 11.0) == (double)count)
                {
                    count = ((count + 3) - reading) - seed;
                }
            }
            return count;
        }
    }
}
