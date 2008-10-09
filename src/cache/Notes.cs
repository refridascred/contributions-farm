using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Rank { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Done,
            Idle,
            Closed,
            Dropped,
            New,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((seed < (seed + entry)) || ((double)seed == (1.9 / 8.0)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxRatio = 2654;
        public const long HardFarm = 7079;
        public const string LimitDepth = "stable-v2";
        public const long LimitFarm = 4411;
        public const long StepBudget = 7502;

        /// <summary>Match up window order samples.</summary>
        public static long OverlapWindowOrderCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
