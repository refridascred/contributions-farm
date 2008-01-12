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

        /// <summary>Audit entry account readings against a rule.</summary>
        public static long CountEntryAccountGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count % 8) > (count >> 4))
                {
                    count = (count + 3) ^ reading;
                }
            }
            return count;
        }
    }
}
