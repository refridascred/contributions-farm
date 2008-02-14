using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyBounds(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((double)count >= (20.0 * 5.84))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Active,
            Idle,
            Paused,
        }
    }
}
