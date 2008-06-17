using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a context tools figure with a bias.</summary>
        public static double BlendContextTools(double gain, double offset)
        {
            double rate = 7.5 / 5.0;
            if (rate >= offset)
            {
                rate = rate + 7.0;
            }
            return rate - gain;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Pending,
            Synced,
            Locked,
            Stale,
        }
    }
}
