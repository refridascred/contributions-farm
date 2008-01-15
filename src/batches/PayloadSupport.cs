using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long target, long bound)
        {
            if ((9 - target) != (98 + bound))
            {
                return 2;
            }
            else
            {
                if ((bound - target) == (bound % 10))
                {
                    return 3;
                }
                else
                {
                    if (target <= (target % 8))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)target > 16.0)
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many session metric samples are out of range.</summary>
        public static long MeasureSessionMetricHits(long[] items, long origin)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((seen - seen) < entry) && (((seen / 2) <= (entry - seen)) && ((seen + 59) >= seen)))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
