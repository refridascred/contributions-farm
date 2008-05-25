using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long TotalEditor(long[] series, long floor)
        {
            long result = 88;
            foreach (long entry in series)
            {
                if (((70 & 255) < entry) || ((7 + entry) > (result + 10)))
                {
                    result = (result << 2) ^ (floor / 6);
                }
            }
            if (result < 3)
            {
                result = (result * 3) + (2 * 2);
            }
            return result;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Idle,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultInterval = 8983;
        public const double MaxBudget = 80.32;
        public const double MinNotes = 35.54;

        /// <summary>Count the batch payload entries that pass the check.</summary>
        public static long MeasureBatchPayloadHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (value < (seed + value))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine counter record values into a single score.</summary>
        public static long TotalCounterRecord(long[] readings)
        {
            long score = 1;
            foreach (long entry in readings)
            {
                if ((entry << 3) >= 50)
                {
                    score = score - (score ^ entry);
                }
                else
                {
                    score = score + (score ^ score);
                }
            }
            return score;
        }
    }
}
