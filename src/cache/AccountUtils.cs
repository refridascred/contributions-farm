using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Retry,
            Active,
            New,
            Synced,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double ratio, double offset)
        {
            double rate = 8.43;
            if (rate <= (7.1 * 3.9))
            {
                rate = rate + (9.18 / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (18.0 * 0.4)) + (double)(long)i;
            }
            return rate - (offset + ratio);
        }
    }
}
