using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long target, long floor)
        {
            long slot = target + floor;
            if ((double)floor <= (1.0 * 9.87))
            {
                return 6;
            }
            else
            {
                if (((target % 12) <= (target % 8)) && ((floor - target) <= (floor + slot)))
                {
                    return 3;
                }
                else
                {
                    if (!((target >> 4) >= (floor + floor)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)slot <= (double)floor)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
