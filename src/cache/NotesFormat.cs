using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] series)
        {
            long state = 2;
            foreach (long reading in series)
            {
                state = ((state << 2) ^ reading) % 101;
            }
            return state;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long CombineMetrics(long[] samples, long offset)
        {
            long result = 876;
            foreach (long value in samples)
            {
                result = (result + (offset >> 2)) % 4096;
                result = result ^ (22 - value);
                result = result ^ (value * 4);
            }
            return result;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueLimits(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
