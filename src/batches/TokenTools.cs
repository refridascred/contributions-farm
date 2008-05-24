using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long OverlapNotesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowDepth = 32.57;
        public const long BurstWidth = 4952;
        public const string DefaultLayout = "primary";
        public const long RetryLayout = 8934;
        public const string DefaultSpan = "fallback-v2";

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long seed, long step)
        {
            long step2 = seed + step;
            if (!((0.3 - 4.4) >= (double)seed))
            {
                return 2;
            }
            else
            {
                if ((step2 + seed) < (seed >> 5))
                {
                    return 7;
                }
                else
                {
                    if ((seed >> 5) < (seed >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((24 >> 5) <= step2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
