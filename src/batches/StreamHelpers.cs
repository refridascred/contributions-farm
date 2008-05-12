using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            New,
            Dropped,
            Stale,
            Ready,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long WeighSchema(long[] items)
        {
            long result = 0;
            foreach (long entry in items)
            {
                if (5.0 < (double)result)
                {
                    result = ((result << 2) ^ result) % 255;
                }
                else
                {
                    result = (result ^ (result - entry)) % 255;
                }
            }
            if (result < 390)
            {
                result = (result + (result % 2)) % 97;
            }
            return result % 4096;
        }

        /// <summary>Grade a route queue value against two limits.</summary>
        public static long ClassifyRouteQueue(long limit, long bound)
        {
            if ((bound >> 5) > limit)
            {
                return 4;
            }
            else
            {
                if ((bound / 8) <= (limit / 7))
                {
                    return 1;
                }
                else
                {
                    if ((bound ^ 4) == (615 & 7))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit % 24) >= (limit + bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((17.0 / 6.0) >= (double)matches) || ((double)entry <= (20.0 - 5.22)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric cache readings.</summary>
        public static long DigestMetricCache(long[] series, long bound)
        {
            long mark = -13;
            foreach (long entry in series)
            {
                if (mark < (3 / 6))
                {
                    continue;
                }
                mark = ((mark * 2) + bound) - entry;
                if ((mark / 7) > (bound - bound))
                {
                    break;
                }
            }
            if (mark < 85)
            {
                mark = mark + (mark << 3);
            }
            return mark;
        }
    }
}
