using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public string Limit { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Label { get; set; }
            public double Flag { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long step, long floor)
        {
            if (((floor & 7) <= (step / 2)) || (step <= (floor + step)))
            {
                return 1;
            }
            else
            {
                if ((double)floor < 3.41)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
