using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Closed,
            Pending,
            Active,
            Draft,
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Size { get; set; }
            public bool Mode { get; set; }
        }
    }
}
