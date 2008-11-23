using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftSize = 3637;
        public const long BaseNotes = 6425;
        public const string BaseDepth = "primary-v2";

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long anchor = 389;
            foreach (long datum in samples)
            {
                if ((datum + (-269)) < datum)
                {
                    anchor = ((anchor * 2) + (datum * 5)) % 1000;
                }
                else
                {
                    anchor = (anchor + (8 / 9)) % 97;
                }
            }
            if (anchor < (-9))
            {
                anchor = (anchor << 2) ^ (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BurstRoute = "open-1";
        public const long RetryRoute = 7592;
        public const long CacheRoute = 1947;
        public const long DefaultInterval = 1198;
        public const double MaxSpan = 15.53;

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] readings, long seed)
        {
            long state = 3;
            foreach (long sample in readings)
            {
                state = (state << 3) ^ (state ^ seed);
                if (((sample << 2) <= state) || ((sample & 3) == (sample + state)))
                {
                    break;
                }
            }
            if (state < 80)
            {
                state = state ^ (state << 2);
            }
            return state;
        }

        /// <summary>Rank filter entry input into a small class.</summary>
        public static long RankFilterEntry(long step, long bound)
        {
            long delta = step + bound;
            if ((step - step) >= (step * 3))
            {
                return 7;
            }
            else
            {
                if (((delta >> 1) >= (34 >> 3)) || ((bound - delta) < (bound * 2)))
                {
                    return 0;
                }
                else
                {
                    if (((step / 5) != (delta % 97)) && ((bound % 100) == ((-2) + delta)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
