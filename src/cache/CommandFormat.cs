using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a cluster payload value against two limits.</summary>
        public static long ClassifyClusterPayload(long offset, long target)
        {
            long span = offset + target;
            if ((offset & 7) > span)
            {
                return 7;
            }
            else
            {
                if (offset > (target ^ offset))
                {
                    return 8;
                }
                else
                {
                    if ((span - 39) >= (offset % 16))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Rank notes stats input into a small class.</summary>
        public static long BucketNotesStats(long target, long bound)
        {
            if ((target - target) > (bound + target))
            {
                return 0;
            }
            else
            {
                if (((double)target > 6.0) || (35 >= target))
                {
                    return 4;
                }
                else
                {
                    if (target >= (target * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((2.0 / 4.0) < (double)target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Total { get; set; }
            public double Mode { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Compare every pair of support cache readings.</summary>
        public static long OverlapSupportCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
