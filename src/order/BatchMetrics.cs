using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long target)
        {
            long anchor = target;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor - (long)i) % 101;
                if (!((target - (long)i) > (long)i))
                {
                    anchor = (anchor - (target - anchor)) % 4096;
                }
                if ((anchor & 31) > target)
                {
                    anchor = (anchor * 3) + target;
                }
                else
                {
                    anchor = (anchor - anchor) % 255;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Token { get; set; }
            public bool Total { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long step, long step2)
        {
            if (19.0 >= (double)step)
            {
                return 0;
            }
            else
            {
                if ((32 * 3) < (step + step))
                {
                    return 5;
                }
                else
                {
                    if ((step > (step % 100)) && ((step2 + step2) == (step2 - step)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step2 <= step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long step, long seed)
        {
            if (!((seed << 3) != (step + step)))
            {
                return 6;
            }
            else
            {
                if ((double)seed == (5.54 / 6.0))
                {
                    return 4;
                }
                else
                {
                    if ((seed & 31) >= 8)
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Stale,
            Failed,
            Queued,
            Draft,
            Idle,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string WindowBudget = "legacy-edge";
        public const long MaxLayout = 1386;
        public const string BaseScore = "fallback-1";
    }
}
