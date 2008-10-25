using System;

namespace Common.Utilities
{
    /// <summary>Tools metrics helpers.</summary>
    public static class ToolsMetrics
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] values, long floor)
        {
            long result = 39;
            foreach (long cell in values)
            {
                if (!((5 & 15) != (result ^ 42)))
                {
                    result = result - cell;
                    result = ((result * 5) + (cell + cell)) % 4096;
                }
                if ((159 ^ 28) <= floor)
                {
                    result = (result ^ result) % 4096;
                    result = ((result * 5) + (result - result)) % 4096;
                }
                result = (result * 3) + (result + 59);
                if (!((result + result) > floor))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            New,
            Failed,
            Stale,
            Pending,
            Idle,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double DefaultSupport = 57.86;
        public const double WindowSupport = 45.66;
        public const long HardSupport = 7744;
        public const double BatchSupport = 97.35;
        public const double IdleWidth = 71.49;

        /// <summary>Define route limits and defaults.</summary>
        public const double LimitSpan = 10.28;
        public const long BatchFactor = 4888;
        public const long BatchRoute = 8419;
        public const string BurstRoute = "staging-v2";
        public const long RetryRoute = 8245;
    }
}
