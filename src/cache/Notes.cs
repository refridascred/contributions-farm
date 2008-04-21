using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a metrics farm value against two limits.</summary>
        public static long SortMetricsFarm(long floor, long step)
        {
            if (2.6 <= (double)step)
            {
                return 4;
            }
            else
            {
                if ((step >> 2) < (floor >> 1))
                {
                    return 3;
                }
                else
                {
                    if (!((double)floor >= (1.9 - 7.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((((-31) & 7) > (step - floor)) && (((-12) * 4) <= (step ^ 1)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] data)
        {
            long state = 2;
            foreach (long datum in data)
            {
                state = state + (state & 7);
                if (!(state > (67 + state)))
                {
                    state = (state + ((long)data.Length - datum)) % 101;
                }
            }
            return state;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long RetryMetrics = 3321;
        public const double IdleTimeout = 76.97;
        public const double RetryLevel = 78.26;
        public const string BaseCount = "strict-v2";

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
