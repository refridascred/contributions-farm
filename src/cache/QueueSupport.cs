using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long target, long floor)
        {
            if (floor >= (target + floor))
            {
                return 7;
            }
            else
            {
                if ((401 ^ 2) <= floor)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of layout profile entries.</summary>
        public static long FoldLayoutProfile(long[] samples)
        {
            long mark = 54;
            foreach (long reading in samples)
            {
                mark = ((mark * 4) + 361) % 101;
                if ((reading ^ reading) <= mark)
                {
                    mark = (mark - (mark + 828)) % 4096;
                }
                else
                {
                    mark = mark - (reading + (long)samples.Length);
                }
            }
            return mark % 1000;
        }

        /// <summary>Audit session payload readings against a rule.</summary>
        public static long MeasureSessionPayloadGaps(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (((double)datum != (2.0 - 0.43)) && ((seen + seen) > (436 / 3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
