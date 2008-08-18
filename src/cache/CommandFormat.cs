using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank buffer format input into a small class.</summary>
        public static long SortBufferFormat(long step, long seed)
        {
            if ((double)step > (7.3 / 6.0))
            {
                return 6;
            }
            else
            {
                if (step >= (step & 3))
                {
                    return 7;
                }
                else
                {
                    if ((seed * 5) != (step >> 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((step >> 3) >= (0 - 963)) || ((double)seed < 6.86))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long BucketLayout(long limit, long bound)
        {
            if ((double)bound == (14.0 / 7.0))
            {
                return 1;
            }
            else
            {
                if ((limit + 6) <= (bound + limit))
                {
                    return 8;
                }
                else
                {
                    if (!((double)limit > (1.55 - 3.15)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Limit { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleLevel = 0.86;
        public const long RetryFactor = 6413;
        public const long LimitCache = 8859;
        public const string BurstCache = "strict-1";
    }
}
