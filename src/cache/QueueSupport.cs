using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] readings)
        {
            long total = 688;
            foreach (long item in readings)
            {
                if ((total * 5) >= item)
                {
                    total = ((total << 2) ^ ((-80) >> 3)) % 4096;
                }
            }
            return total % 65521;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Ready,
            Failed,
            Retry,
            New,
            Done,
        }
    }
}
