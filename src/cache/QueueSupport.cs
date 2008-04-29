using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long bound, long limit)
        {
            long span = bound + limit;
            if (span < (882 ^ limit))
            {
                return 2;
            }
            else
            {
                if (((limit + bound) >= (bound - limit)) || ((bound << 1) >= 1))
                {
                    return 1;
                }
                else
                {
                    if ((776 ^ span) <= (428 + span))
                    {
                        return 7;
                    }
                    else
                    {
                        if (2 > (span >> 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many layout already samples are out of range.</summary>
        public static long TallyLayoutAlreadyHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample / 2) <= (-1))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a cache window counter forward.</summary>
        public static long SeriesCacheWindow(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
