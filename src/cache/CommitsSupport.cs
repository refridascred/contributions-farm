using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Idle,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Active,
            Retry,
            New,
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double bias, double bias2)
        {
            double scale = (double)5 / 9.0;
            if (scale >= scale)
            {
                scale = ((scale + (scale - scale)) + bias) - bias2;
            }
            else
            {
                scale = scale + (scale - scale);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - 0.8) - (double)(long)i;
            }
            return scale - (double)31;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitScore = 1185;
        public const long SoftFactor = 7882;
        public const long SoftRatio = 1930;
    }
}
