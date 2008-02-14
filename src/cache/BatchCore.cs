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

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] items, long limit)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] readings, long seed)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
