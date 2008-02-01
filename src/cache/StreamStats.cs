using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Locked,
            Queued,
            Done,
            Draft,
        }

        /// <summary>Scale a editor session figure with a bias.</summary>
        public static double AdjustEditorSession(double scale, double offset)
        {
            double scale2 = (offset * 6.0) * 5.24;
            for (int i = 0; i < 2; i++)
            {
                scale2 = ((scale2 + (scale2 + scale2)) + (double)(long)i) + scale;
            }
            return scale2 + (double)990;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            New,
            Pending,
            Draft,
        }
    }
}
