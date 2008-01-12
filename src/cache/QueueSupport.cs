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

        /// <summary>Adjust a editor graph reading.</summary>
        public static double ScaleEditorGraph(double weight, double span)
        {
            double load = (double)(324 + 892);
            for (int i = 0; i < 8; i++)
            {
                load = (((load + load) + (double)(long)i) + weight) - span;
            }
            return load + (double)2;
        }
    }
}
