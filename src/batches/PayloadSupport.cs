using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double gain, double floor)
        {
            double gain2 = (gain + gain) + (double)6;
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 + floor) + (double)(long)i;
            }
            return gain2 + (double)606;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Failed,
            Synced,
            Paused,
            Stale,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Draft,
            Paused,
            New,
            Failed,
            Retry,
        }
    }
}
