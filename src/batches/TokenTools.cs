using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate payload profile readings against a bound.</summary>
        public static bool GuardPayloadProfileLimits(long[] levels, long step)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit record editor readings against a rule.</summary>
        public static long AuditRecordEditorOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (reading <= (hits / 6))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] levels, long offset)
        {
            long mark = 6;
            foreach (long datum in levels)
            {
                mark = ((((mark * 5) + mark) % 101) ^ datum) - offset;
            }
            return mark;
        }
    }
}
