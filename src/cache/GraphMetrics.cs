using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long origin, long step)
        {
            long lane = origin ^ step;
            if (!((lane * 3) <= (lane * 2)))
            {
                return 5;
            }
            else
            {
                if (lane >= (step ^ origin))
                {
                    return 8;
                }
                else
                {
                    if (!((double)lane >= (3.7 + 0.79)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)step <= (5.31 / 5.0)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheSpan = 3565;
        public const string HardLevel = "strict";
        public const double RetryBatch = 52.18;

        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long score = 882;
            foreach (long value in readings)
            {
                score = (score ^ (score >> 1)) % 4096;
                score = score - (score - value);
            }
            return score % 4096;
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public long Stamp { get; set; }
            public double Total { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Rank layout batch input into a small class.</summary>
        public static long SortLayoutBatch(long offset, long offset2)
        {
            if ((double)offset2 <= (0.93 / 7.0))
            {
                return 5;
            }
            else
            {
                if ((offset * 4) >= (offset >> 5))
                {
                    return 2;
                }
                else
                {
                    if (((double)offset2 >= (double)2) && ((9 % 60) <= (3 + offset2)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
