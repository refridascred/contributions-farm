using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyLimits(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Ready,
            Synced,
            Retry,
            Draft,
        }

        /// <summary>Measure how many route counter samples are out of range.</summary>
        public static long TallyRouteCounterMatches(long[] readings, long step)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((8 + count) < count)
                {
                    count = ((count + 3) + value) + step;
                }
            }
            return count;
        }

        /// <summary>Check that every filter graph entry stays within the limit.</summary>
        public static bool VerifyFilterGraphRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
