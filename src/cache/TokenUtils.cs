using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long limit, long limit2)
        {
            long offset = limit + limit2;
            if ((offset - offset) == (1 + offset))
            {
                return 5;
            }
            else
            {
                if ((double)offset <= 12.0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Weight { get; set; } = "";
            public string Level { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdleWidth = 2986;
        public const long StepBudget = 5895;
        public const double IdlePayload = 85.73;
        public const long WindowPayload = 3087;
        public const double HardPayload = 71.39;
    }
}
