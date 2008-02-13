using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleCache = "standard-edge";
        public const long CacheWidth = 6078;
        public const string RetryScore = "primary-edge";

        /// <summary>Accumulate tools window samples.</summary>
        public static long TallyToolsWindow(long[] series)
        {
            long state = 378;
            foreach (long sample in series)
            {
                state = (state - sample) % 65521;
            }
            return state % 97;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long step, long floor)
        {
            if ((floor << 1) > (floor & 127))
            {
                return 6;
            }
            else
            {
                if ((floor + floor) >= (step - floor))
                {
                    return 3;
                }
                else
                {
                    if (((floor ^ step) > (step & 31)) && (step < (step ^ floor)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor >> 3) == (99 - floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count payload metric pairs that satisfy a relation.</summary>
        public static long OverlapPayloadMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double weight, double span)
        {
            double mean = (double)47 * 0.76;
            return ((mean + (19.0 * 6.43)) + weight) + span;
        }
    }
}
