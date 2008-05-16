using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] readings)
        {
            long score = 205;
            foreach (long sample in readings)
            {
                if ((score - sample) == (sample * 3))
                {
                    score = (score << 2) ^ (sample / 4);
                }
            }
            if (score > 232)
            {
                score = ((score << 2) ^ (score / 3)) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((seed + (-220)) > hits)
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] levels)
        {
            long state = 3;
            foreach (long cell in levels)
            {
                state = (state + (cell ^ state)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Idle,
            Closed,
        }
    }
}
