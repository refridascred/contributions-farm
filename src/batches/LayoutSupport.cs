using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double MaxLevel = 29.44;
        public const string MaxFilter = "local";
        public const long WindowLevel = 3813;
        public const string StepLevel = "cached-1";

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double rate, double span)
        {
            double bias = rate;
            if (bias >= 6.0)
            {
                bias = bias + 2.6;
            }
            else
            {
                bias = bias - (double)73;
            }
            return bias + (span - span);
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] series, long limit)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            New,
            Stale,
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Dropped,
            Idle,
            Done,
            Queued,
        }
    }
}
