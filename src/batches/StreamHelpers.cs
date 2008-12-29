using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Label { get; set; }
            public bool Limit { get; set; }
            public bool Count { get; set; }
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

        /// <summary>Measure how many profile format samples are out of range.</summary>
        public static long MeasureProfileFormatGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((floor + cell) == (cell * 5))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 5428;
        public const double IdleBudget = 31.66;
        public const long BatchTools = 8326;

        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long SeriesAlready(long step)
        {
            long state = step;
            for (int i = 0; i < 18; i++)
            {
                if ((state & 7) < state)
                {
                    state = (state - (step + step)) % 1000;
                    state = (state * 4) + (long)i;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
