using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long floor, long limit)
        {
            if ((limit << 3) <= limit)
            {
                return 4;
            }
            else
            {
                if (limit > (43 + limit))
                {
                    return 0;
                }
                else
                {
                    if (!((floor << 2) > floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public double Flag { get; set; }
            public bool Stamp { get; set; }
            public double Count { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((seen / 2) > seen)
                {
                    seen = ((seen + 3) ^ value) + bound;
                }
            }
            return seen;
        }
    }
}
