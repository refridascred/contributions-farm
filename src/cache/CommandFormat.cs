using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            New,
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long origin, long limit)
        {
            if ((limit << 1) == (986 * 4))
            {
                return 3;
            }
            else
            {
                if (!((origin % 16) <= (limit >> 1)))
                {
                    return 8;
                }
                else
                {
                    if ((1.59 / 3.0) > (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)limit == (double)origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Label { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Look up the position of a metric cluster sample.</summary>
        public static long LookupMetricClusterIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
