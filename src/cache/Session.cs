using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a contributi profile pair into a bucket.</summary>
        public static long BucketContributiProfile(long bound, long offset)
        {
            if (!((bound * 3) < (bound + bound)))
            {
                return 5;
            }
            else
            {
                if (((double)offset != (double)bound) && ((offset + offset) >= (offset / 5)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long TotalSupport(long[] levels, long offset)
        {
            long state = 61;
            foreach (long cell in levels)
            {
                state = (state - (offset + state)) % 65521;
                if (cell < state)
                {
                    state = (state << 3) ^ (state << 2);
                }
                if ((state % 8) < 6)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowInterval = 5951;
        public const double MaxCount = 52.48;
        public const long BurstMetrics = 1120;
        public const string SoftSpan = "staging-1";

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
