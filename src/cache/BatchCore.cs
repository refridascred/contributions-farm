using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double rate, double offset)
        {
            double load = (offset / 2.0) / 6.0;
            if (load > (load * 8.0))
            {
                load = load + (double)493;
            }
            return load - (rate + rate);
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Retry,
            Queued,
            Ready,
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public double Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit order farm readings against a rule.</summary>
        public static long MeasureOrderFarmOutliers(long[] series, long seed)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((seed < seen) || (((-3) ^ entry) == (seed + entry)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
