using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public bool Count { get; set; }
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] items, long step)
        {
            long score = 1;
            foreach (long sample in items)
            {
                if ((step % 100) >= sample)
                {
                    score = (score << 2) ^ (step * 3);
                }
            }
            return score;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long origin, long floor)
        {
            long lane = origin - floor;
            if (((floor - origin) > (7 * 2)) && ((lane >> 5) > (277 << 3)))
            {
                return 3;
            }
            else
            {
                if ((758 / 9) >= origin)
                {
                    return 8;
                }
                else
                {
                    if ((double)origin < (1.89 * 18.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((origin & 127) < lane) && ((floor + origin) <= origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Retry,
            Idle,
            New,
            Dropped,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 3421;
        public const long HardSpan = 292;
        public const long WindowTimeout = 3628;
    }
}
