using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (((double)seed == (2.3 * 6.1)) || (((double)tally > (double)2) || ((double)value >= (7.1 / 7.0))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((184 - entry) <= (tally ^ tally)) || ((tally + tally) != (279 + tally)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long floor, long bound)
        {
            long cur = floor ^ bound;
            if ((double)floor == (double)bound)
            {
                return 4;
            }
            else
            {
                if ((bound + cur) >= (681 << 1))
                {
                    return 5;
                }
                else
                {
                    if (!((cur + bound) < (floor + 950)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
