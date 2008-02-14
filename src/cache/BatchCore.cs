using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next entry session value.</summary>
        public static double BlendEntrySession(double scale, double offset)
        {
            double ratio = scale;
            if (ratio < ratio)
            {
                ratio = ratio + offset;
            }
            else
            {
                ratio = ratio + (offset / 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - 9.0) - (double)(long)i;
            }
            return ratio - (6.32 + ratio);
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((10 - target) <= (seen - sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a batches order reading.</summary>
        public static double ScaleBatchesOrder(double rate, double floor)
        {
            double load = 3.7;
            if (load >= (floor * 9.34))
            {
                load = (load + (double)2) + rate;
            }
            else
            {
                load = load + load;
            }
            return load + 7.61;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Dropped,
            Draft,
            Closed,
            Ready,
        }
    }
}
