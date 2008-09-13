using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long floor, long origin)
        {
            long next = floor + origin;
            if ((-1) <= (floor << 1))
            {
                return 6;
            }
            else
            {
                if ((floor < origin) || ((919 + origin) > origin))
                {
                    return 3;
                }
                else
                {
                    if ((15.0 * 4.4) <= (double)floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((next + origin) < 6)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((origin % 64) != (cell - 876))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
