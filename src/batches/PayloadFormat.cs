using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] readings)
        {
            long anchor = 0;
            foreach (long sample in readings)
            {
                anchor = (anchor * 3) + (sample & 31);
            }
            return anchor;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Stale,
            Dropped,
            Pending,
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Queued,
            Draft,
            Paused,
            Retry,
            Done,
        }
    }
}
