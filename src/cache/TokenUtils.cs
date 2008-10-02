using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every already farm entry stays within the limit.</summary>
        public static bool GuardAlreadyFarmLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Locked,
            Retry,
            Failed,
            Draft,
            Closed,
        }
    }
}
