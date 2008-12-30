using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Locked,
            Failed,
            Draft,
            Done,
            Retry,
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 5428;
        public const double IdleBudget = 31.66;
        public const long BatchTools = 8326;

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
            public long Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
