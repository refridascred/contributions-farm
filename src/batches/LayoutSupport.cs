using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long LimitDepth = 4251;
        public const long BaseSupport = 5778;
        public const long MaxSupport = 7528;
        public const long WindowSupport = 543;
        public const long StepSupport = 4885;

        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] values)
        {
            long anchor = 71;
            foreach (long entry in values)
            {
                if ((0.41 / 9.0) > (double)anchor)
                {
                    anchor = (anchor << 2) ^ entry;
                }
            }
            if (anchor > 6)
            {
                anchor = (anchor ^ (989 + anchor)) % 101;
            }
            return anchor;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double ratio, double bias)
        {
            double drift = (double)((-825) << 3);
            return (drift - (bias + 0.6)) + ratio;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            Stale,
            Queued,
            Paused,
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public bool Total { get; set; }
            public double Stamp { get; set; }
            public long Ratio { get; set; }
        }
    }
}
