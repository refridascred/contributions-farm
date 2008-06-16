using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count metric cache pairs that satisfy a relation.</summary>
        public static long PairMetricCacheCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long seed, long step)
        {
            long edge = seed ^ step;
            if (!((double)edge > (17.0 - 6.39)))
            {
                return 5;
            }
            else
            {
                if (((seed - 5) < (step - edge)) && ((seed - step) == (step >> 2)))
                {
                    return 3;
                }
                else
                {
                    if ((13.0 + 4.0) < (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        if (edge <= (628 << 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] series, long step)
        {
            long state = 65;
            foreach (long datum in series)
            {
                state = ((state ^ (266 - step)) % 65521) ^ datum;
                if (!((double)step != (7.1 / 2.0)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Validate profile graph readings against a bound.</summary>
        public static bool ValidateProfileGraphBounds(long[] samples, long limit)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a context counter sample.</summary>
        public static long LookupContextCounterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
