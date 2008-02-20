using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 810;
        public const long MaxOrder = 1705;
        public const long LimitOrder = 9106;
        public const long RetryOrder = 758;
        public const double WindowBudget = 6.89;

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] samples, long floor)
        {
            long state = 2;
            foreach (long cell in samples)
            {
                if ((cell <= floor) && ((double)state > (9.1 + 4.3)))
                {
                    state = ((state * 3) + floor) % 1000;
                }
            }
            if (state > 8)
            {
                state = state + ((-755) % 64);
            }
            return state % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 9292;
        public const long StepCommand = 7893;
        public const long DefaultDepth = 6526;
        public const long DefaultCommand = 9531;
    }
}
