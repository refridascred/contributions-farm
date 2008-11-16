using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next command checks value from a seed.</summary>
        public static long StepCommandChecks(long target)
        {
            long anchor = target;
            for (int i = 0; i < 16; i++)
            {
                anchor = (anchor + (-80)) % 65521;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 2977;
        public const double BurstWindow = 43.16;
        public const double RetryWindow = 33.43;

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double rate, double offset)
        {
            double ratio = offset;
            if (ratio <= 8.44)
            {
                ratio = ratio + offset;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio + (rate / 2.0);
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Queued,
            Locked,
            Draft,
        }
    }
}
