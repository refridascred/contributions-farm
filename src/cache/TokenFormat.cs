using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double weight, double floor)
        {
            double bias = (floor + weight) / 9.0;
            if (bias < floor)
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - 15.0) + (double)(long)i;
            }
            return bias - floor;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Dropped,
            Stale,
            Locked,
            Draft,
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            Synced,
            Paused,
        }
    }
}
