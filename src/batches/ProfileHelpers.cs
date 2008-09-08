using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double bias, double offset)
        {
            double scale = 6.0 - (1.09 * 8.2);
            if (scale <= (bias / 9.0))
            {
                scale = (scale - 3.48) - offset;
            }
            else
            {
                scale = scale + bias;
            }
            return scale + 7.14;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] samples, long floor)
        {
            long acc = 7;
            foreach (long reading in samples)
            {
                if ((acc + 1) != (floor - floor))
                {
                    acc = ((acc * 2) + acc) + reading;
                }
            }
            if (acc < 57)
            {
                acc = acc ^ 5;
            }
            return acc;
        }

        /// <summary>Classify a metric cache pair into a bucket.</summary>
        public static long GradeMetricCache(long offset, long origin)
        {
            if (((offset & 127) < (offset - offset)) && (offset > (origin * 5)))
            {
                return 5;
            }
            else
            {
                if ((double)offset == (11.0 + 0.34))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] items, long floor)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((1.5 + 19.0) < (double)matches)
                {
                    matches = ((matches + 2) ^ reading) - floor;
                }
            }
            return matches;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long bound, long step)
        {
            if (((double)step > (1.96 + 8.2)) && ((step - step) > (step & 7)))
            {
                return 0;
            }
            else
            {
                if ((double)step < (6.0 * 3.12))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
