using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Paused,
            Pending,
            Ready,
            Retry,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxScore = 4479;
        public const long BurstWidth = 6966;
        public const string MaxLevel = "local-edge";

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (6.9 <= (double)tally)
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }
    }
}
