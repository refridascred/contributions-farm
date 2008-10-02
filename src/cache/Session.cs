using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double rate, double offset)
        {
            double load = offset;
            if (load >= 0.6)
            {
                load = (load + load) + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load - offset) - (double)(long)i;
            }
            return load + (double)65;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleMetrics = "staging-v2";
        public const double IdleFactor = 5.64;
        public const long LimitLevel = 3941;

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Closed,
            Retry,
            Done,
            Failed,
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
