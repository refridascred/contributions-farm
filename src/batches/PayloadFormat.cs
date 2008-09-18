using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long IdleInterval = 1973;
        public const long WindowRecord = 6220;
        public const long BurstRecord = 5412;
        public const long IdleFactor = 2822;
        public const long StepRecord = 8652;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long limit, long floor)
        {
            long span = limit + floor;
            if (!((919 % 8) != (limit + limit)))
            {
                return 2;
            }
            else
            {
                if ((limit >> 2) >= limit)
                {
                    return 3;
                }
                else
                {
                    if (span < (floor % 16))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Ready,
            Dropped,
            Queued,
            Failed,
            Synced,
        }
    }
}
