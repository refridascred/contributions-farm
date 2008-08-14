using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long TotalSession(long[] items, long target)
        {
            long anchor = 0;
            foreach (long sample in items)
            {
                if (anchor < (sample * 3))
                {
                    anchor = anchor ^ (663 << 1);
                }
                else
                {
                    anchor = anchor ^ (anchor + target);
                }
                if ((sample / 7) < (sample & 127))
                {
                    break;
                }
            }
            if (anchor < 4)
            {
                anchor = (anchor - (target << 2)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountGaps(long[] readings, long seed)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((matches << 2) > (seed / 3)))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Done,
            Idle,
            New,
            Failed,
        }
    }
}
