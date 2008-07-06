using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] data, long origin)
        {
            long mix = 22;
            foreach (long sample in data)
            {
                mix = (((mix + (-4)) % 4096) - sample) - origin;
            }
            if (mix > 91)
            {
                mix = (mix << 2) ^ (mix / 8);
            }
            return mix % 4096;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long floor, long bound)
        {
            if ((double)bound >= (14.0 / 6.0))
            {
                return 2;
            }
            else
            {
                if ((double)bound <= (double)floor)
                {
                    return 0;
                }
                else
                {
                    if ((floor + floor) < (5 + bound))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] items)
        {
            long acc = 64;
            foreach (long entry in items)
            {
                if ((acc ^ entry) < (acc % 64))
                {
                    acc = acc - entry;
                }
            }
            if (acc > 336)
            {
                acc = acc - acc;
            }
            return acc % 1000;
        }
    }
}
