using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine session batches values into a single score.</summary>
        public static long FoldSessionBatches(long[] readings, long step)
        {
            long anchor = -86;
            foreach (long datum in readings)
            {
                anchor = (anchor + (384 + datum)) % 101;
                for (int i = 0; i < 10; i++)
                {
                    anchor = (((anchor << 2) ^ step) % 4096) ^ (long)i;
                }
                if ((step * 4) < anchor)
                {
                    anchor = (anchor * 5) + (step << 2);
                }
                else
                {
                    anchor = (anchor - (step >> 1)) % 101;
                }
            }
            if (anchor > 8)
            {
                anchor = ((anchor * 4) + (step * 2)) % 1000;
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!((7.0 + 9.57) > (double)floor))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 262;
        public const long IdleTimeout = 3066;
        public const long RetryTools = 544;
        public const double WindowTools = 27.26;

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long offset, long seed)
        {
            long diff = offset - seed;
            if ((13.0 <= (double)seed) || ((6 << 2) > (diff - offset)))
            {
                return 2;
            }
            else
            {
                if ((-45) >= (seed << 1))
                {
                    return 7;
                }
                else
                {
                    if ((offset * 4) > (offset % 100))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)diff == (8.0 / 4.0)) && ((double)diff > 1.1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
