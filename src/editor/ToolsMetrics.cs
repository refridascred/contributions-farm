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

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double LimitSpan = 10.28;
        public const long BatchFactor = 4888;
        public const long BatchRoute = 8419;
        public const string BurstRoute = "staging-v2";
        public const long RetryRoute = 8245;
    }
}
