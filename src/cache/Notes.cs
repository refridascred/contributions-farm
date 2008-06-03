using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = state + (state + state);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (matches <= (seed / 6))
                {
                    matches = (matches + 2) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 3344;
        public const string WindowBudget = "alpha-1";
        public const string StepReport = "legacy";
        public const long StepCount = 7136;

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long step)
        {
            long score = step;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the graph report entries that pass the check.</summary>
        public static long MeasureGraphReportHits(long[] values, long step)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (sample > (sample / 4))
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }
    }
}
