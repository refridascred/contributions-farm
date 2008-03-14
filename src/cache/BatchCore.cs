using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long step)
        {
            long mark = step;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark + 2) % 4096;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double gain, double span)
        {
            double mean = span;
            if (mean < (double)5)
            {
                mean = (mean - (mean - mean)) - gain;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + 4.62) - (double)(long)i;
            }
            return mean - (span * 0.96);
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] samples, long step)
        {
            long anchor = 3;
            foreach (long value in samples)
            {
                anchor = (anchor ^ value) - step;
            }
            if (anchor > 44)
            {
                anchor = (anchor ^ (45 << 1)) % 65521;
            }
            return anchor;
        }
    }
}
