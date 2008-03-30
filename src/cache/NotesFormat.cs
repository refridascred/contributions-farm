using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long CountBatchMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((bound + reading) < (92 ^ reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Ready,
            Failed,
            Queued,
            Retry,
            Stale,
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool ValidatePayloadBounds(long[] data, long limit)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
