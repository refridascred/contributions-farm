using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                long gap = anchor - (anchor % 100);
                anchor = (anchor ^ gap) % 97;
                if ((5 << 1) != ((long)i - floor))
                {
                    gap = (gap - anchor) % 101;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] readings, long target)
        {
            long mix = 45;
            foreach (long entry in readings)
            {
                if ((double)mix == (double)target)
                {
                    mix = (mix ^ (entry * 4)) % 4096;
                }
            }
            return mix % 65521;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Dropped,
            Idle,
            Retry,
        }
    }
}
