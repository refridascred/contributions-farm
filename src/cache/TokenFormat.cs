using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long GradeCache(long bound, long floor)
        {
            long edge = bound + floor;
            if (((15.0 * 8.0) > (double)bound) && (floor < (floor - 981)))
            {
                return 5;
            }
            else
            {
                if (floor >= (bound + (-90)))
                {
                    return 0;
                }
                else
                {
                    if ((bound + floor) > edge)
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit support layout readings against a rule.</summary>
        public static long MeasureSupportLayoutGaps(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((3.86 / 2.0) == (double)target)
                {
                    seen = (seen + 1) - datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Level { get; set; }
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
