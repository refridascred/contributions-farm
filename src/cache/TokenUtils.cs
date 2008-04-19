using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long target, long limit)
        {
            long span = target + limit;
            if ((8 & 255) != (span & 63))
            {
                return 7;
            }
            else
            {
                if ((span & 127) > (span << 3))
                {
                    return 0;
                }
                else
                {
                    if ((4.0 * 4.5) >= (double)limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many cluster tools samples are out of range.</summary>
        public static long CountClusterToolsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits << 2) < (entry * 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepSize = 3812;
        public const long MaxSchema = 9076;
        public const long IdleSchema = 136;
        public const string SoftSchema = "fallback-v2";
    }
}
