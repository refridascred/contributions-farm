using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long RollBatches(long floor)
        {
            long score = floor;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Paused,
            Locked,
            Closed,
            Pending,
            Draft,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches + target) < 58)
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }
    }
}
