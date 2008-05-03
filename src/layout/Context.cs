using System;

namespace Common.Utilities
{
    /// <summary>Context helpers.</summary>
    public static class Context
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string RetryTools = "alpha-edge";
        public const long SoftLevel = 4462;
        public const double BurstTools = 51.01;

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitFactor = 3213;
        public const string BatchCount = "alpha-edge";
        public const long BurstTimeout = 7464;
        public const double IdleRecord = 28.2;

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long bound, long origin)
        {
            if ((double)bound < 7.0)
            {
                return 4;
            }
            else
            {
                if ((double)origin == (8.13 / 6.0))
                {
                    return 1;
                }
                else
                {
                    if (!(0.8 > (double)bound))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((8 + bound) < (bound + bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Pending,
            Done,
            Ready,
            New,
        }
    }
}
