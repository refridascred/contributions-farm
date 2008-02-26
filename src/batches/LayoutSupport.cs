using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 863;
        public const long BatchSupport = 241;
        public const string HardInterval = "standard-1";

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long origin, long bound)
        {
            if ((bound - 36) <= bound)
            {
                return 2;
            }
            else
            {
                if ((origin << 3) != (69 % 24))
                {
                    return 8;
                }
                else
                {
                    if ((bound <= ((-371) * 5)) && (bound >= (origin / 7)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Limit { get; set; }
            public double Label { get; set; }
            public double Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Queued,
            Locked,
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Draft,
            Retry,
            Dropped,
            Ready,
        }
    }
}
