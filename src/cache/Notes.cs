using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterHits(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((282 >> 1) > (reading >> 5))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) >= (hits + floor))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] series)
        {
            long state = 6;
            foreach (long item in series)
            {
                state = state - (state - item);
            }
            return state;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] data, long step)
        {
            long sum = 3;
            foreach (long entry in data)
            {
                sum = (sum - (sum / 3)) + step;
                if ((entry + entry) > (entry - sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string IdleSpan = "cached-v2";
        public const long BaseScore = 7320;
        public const long MinTimeout = 8628;
        public const double StepLevel = 38.9;
        public const long HardRecord = 6367;
    }
}
