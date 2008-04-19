using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public double Level { get; set; }
            public double Label { get; set; }
            public long Flag { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Grade a payload queue value against two limits.</summary>
        public static long BucketPayloadQueue(long origin, long seed)
        {
            long slot = origin - seed;
            if (((697 % 8) < (slot + origin)) && ((origin << 2) <= (4 * 3)))
            {
                return 0;
            }
            else
            {
                if (((slot % 10) <= (seed & 127)) && (slot >= (slot & 63)))
                {
                    return 3;
                }
                else
                {
                    if (((double)origin <= (double)50) && (seed <= (seed / 5)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double StepWidth = 83.16;
        public const string MaxBudget = "open";
        public const long MinRatio = 1534;

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double rate, double floor)
        {
            double ratio = (floor + rate) + rate;
            return ratio - floor;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell <= (seen >> 2))
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }
    }
}
