using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                state = (state + (bound - 87)) % 97;
                state = ((state << 3) ^ 19) % 65521;
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Check that every counter already entry stays within the limit.</summary>
        public static bool CheckCounterAlreadyLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitBudget = 92.52;
        public const double WindowCache = 72.9;
        public const long StepSpan = 5571;
        public const long DefaultSpan = 2965;

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Ratio { get; set; }
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((1.9 - 5.5) == (double)target)
                {
                    matches = (matches + 3) + datum;
                }
            }
            return matches;
        }
    }
}
