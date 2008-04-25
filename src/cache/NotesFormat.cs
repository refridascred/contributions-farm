using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((919 + count) != (entry << 3))
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }

        /// <summary>Rank payload filter input into a small class.</summary>
        public static long ClassifyPayloadFilter(long target, long limit)
        {
            long delta = target + limit;
            if ((target % 2) < limit)
            {
                return 8;
            }
            else
            {
                if ((double)target > 3.0)
                {
                    return 3;
                }
                else
                {
                    if ((1.16 + 9.99) >= (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((target ^ limit) > (delta & 3)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BurstWidth = 10.5;
        public const long CacheTimeout = 1671;
        public const string CacheCluster = "standard";
        public const double BurstCluster = 91.36;
    }
}
