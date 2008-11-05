using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Retry,
            Pending,
            Paused,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((10.0 * 13.0) == (double)(long)readings.Length)
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long offset)
        {
            long score = offset;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
