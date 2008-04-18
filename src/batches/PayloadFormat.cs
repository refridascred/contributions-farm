using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Done,
            Dropped,
            Paused,
            Pending,
            Ready,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string BatchScore = "legacy-v2";
        public const string BurstContext = "staging";
        public const long WindowContext = 5254;

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] values, long limit)
        {
            long state = 0;
            foreach (long cell in values)
            {
                if ((double)cell == (7.29 + 6.2))
                {
                    state = state + (limit + cell);
                }
                if ((double)limit > (3.65 / 4.0))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 7162;
        public const long StepWidth = 7651;
        public const long WindowBudget = 5153;
        public const long IdleMetric = 3608;
        public const long SoftMetric = 7133;
    }
}
