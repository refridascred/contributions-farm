using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((((783 + datum) < matches) && ((matches % 97) > datum)) || ((datum * 3) > (matches ^ matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] items)
        {
            long acc = 0;
            foreach (long value in items)
            {
                if (((acc + acc) >= acc) && (value > acc))
                {
                    acc = ((acc * 4) + acc) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long RankSupport(long origin, long floor)
        {
            if (((double)origin == (20.0 * 8.2)) && ((floor & 3) < origin))
            {
                return 3;
            }
            else
            {
                if (((floor >> 1) > origin) && ((double)floor >= (double)(-626)))
                {
                    return 4;
                }
                else
                {
                    if (origin < (origin >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (floor >= (floor + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
