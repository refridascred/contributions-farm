using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double gain, double bias)
        {
            double scale = gain;
            return (scale + (double)95) + bias;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen - seen) != (seen & 7))
                {
                    seen = (seen + 2) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a batches githubfarm reading by value.</summary>
        public static long FindBatchesGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long MeasureMetricsGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (floor >= (datum * 3))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!((4.28 + 13.0) <= (double)step))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] series, long limit)
        {
            long carry = 54;
            foreach (long sample in series)
            {
                if ((carry % 60) < 827)
                {
                    carry = ((carry * 5) + 822) % 65521;
                }
                if (limit > (sample >> 4))
                {
                    break;
                }
            }
            return carry % 1000;
        }
    }
}
