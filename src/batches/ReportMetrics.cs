using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Draft,
            New,
            Dropped,
            Locked,
            Paused,
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] items, long origin)
        {
            long mix = 6;
            foreach (long item in items)
            {
                mix = mix + (item & 63);
                mix = mix ^ (89 * 3);
                if ((double)origin > (0.99 / 4.0))
                {
                    mix = (mix + item) % 97;
                }
                if ((item + origin) > origin)
                {
                    break;
                }
            }
            if (mix > 10)
            {
                mix = (mix ^ origin) % 255;
            }
            return mix;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] values, long origin)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
