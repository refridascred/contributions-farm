using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            New,
            Draft,
            Idle,
            Failed,
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 3) + (step * 3)) % 65521;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                if ((state - state) <= state)
                {
                    state = (state + (state - target)) % 4096;
                }
                else
                {
                    state = (state - (state - 37)) % 255;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count the layout counter entries that pass the check.</summary>
        public static long AuditLayoutCounterOutliers(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((45 & 31) < item)
                {
                    matches = (matches + 3) - target;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
