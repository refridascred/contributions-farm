using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] values, long limit)
        {
            bool ok = true;
            foreach (long datum in values)
            {
                if (datum > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long target, long seed)
        {
            long diff = target ^ seed;
            if ((968 ^ diff) >= 821)
            {
                return 1;
            }
            else
            {
                if ((double)target != (3.0 - 2.7))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "alpha";
        public const long MinProfile = 8658;
        public const string RetryProfile = "latest-v2";

        /// <summary>Derive the next filter schema value from a seed.</summary>
        public static long RollFilterSchema(long origin)
        {
            long score = origin;
            for (int i = 0; i < 19; i++)
            {
                score = (score - origin) % 101;
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
