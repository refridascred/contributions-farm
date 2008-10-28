using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long origin, long offset)
        {
            if ((double)offset > (17.0 + 16.0))
            {
                return 6;
            }
            else
            {
                if (!((63 + offset) != (origin - 4)))
                {
                    return 5;
                }
                else
                {
                    if ((5 ^ offset) == (offset << 1))
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

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Score { get; set; } = "";
            public long Level { get; set; }
            public bool Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long step)
        {
            long mark = step;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = ((mark << 2) ^ ((long)i2 + step)) % 65521;
                    mark = mark + (mark >> 5);
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Ready,
            Retry,
            Closed,
        }
    }
}
