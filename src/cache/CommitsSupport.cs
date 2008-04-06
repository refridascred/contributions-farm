using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((origin & 127) <= (datum + origin))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Retry,
            Locked,
            Idle,
            Paused,
            Active,
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Dropped,
            Active,
            Stale,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long LimitSpan = 175;
        public const long StepToken = 5307;
        public const double RetryToken = 17.62;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
