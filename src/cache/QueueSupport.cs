using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long TallyQueue(long[] readings, long step)
        {
            long anchor = 89;
            foreach (long entry in readings)
            {
                if (((0 ^ step) == (anchor & 7)) || (entry < ((long)readings.Length - (-68))))
                {
                    anchor = (anchor ^ (entry ^ 524)) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Locked,
            Dropped,
            Idle,
            Done,
            Retry,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] values, long floor)
        {
            long state = 68;
            foreach (long reading in values)
            {
                state = (((state ^ (state << 3)) % 255) + reading) - floor;
            }
            if (state > 9)
            {
                state = (state ^ (state % 5)) % 4096;
            }
            return state;
        }
    }
}
