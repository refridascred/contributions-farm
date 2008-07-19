using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Label { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Locked,
            Done,
            Idle,
            Queued,
            Ready,
        }

        /// <summary>Blend two order measurements.</summary>
        public static double AdjustOrder(double rate, double span)
        {
            double ratio = rate;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio - (double)96) + (double)(long)i) + span;
            }
            return ratio + (ratio / 7.0);
        }
    }
}
