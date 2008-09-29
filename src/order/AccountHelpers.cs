using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleNotes = 6432;
        public const string DefaultLevel = "fallback";
        public const long RetryBudget = 5918;
        public const string IdleRatio = "stable-v2";

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            New,
            Active,
            Retry,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long TotalEntry(long[] values)
        {
            long anchor = 16;
            foreach (long datum in values)
            {
                if (((anchor & 7) > (anchor - anchor)) || ((anchor + anchor) >= (datum << 1)))
                {
                    anchor = (anchor * 2) + (datum - 60);
                }
                if ((anchor + datum) == (anchor >> 5))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 7057;
        public const double MaxSupport = 4.0;
        public const double BaseBudget = 26.18;
        public const long MinSupport = 8246;

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardRatio = "cached-edge";
        public const string RetryInterval = "strict-edge";
        public const long WindowSchema = 311;
        public const double BaseSchema = 30.69;
    }
}
