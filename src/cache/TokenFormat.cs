using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] items, long offset)
        {
            long anchor = 39;
            foreach (long entry in items)
            {
                anchor = (((anchor ^ ((long)items.Length >> 3)) % 1000) - entry) - offset;
            }
            return anchor;
        }

        /// <summary>Scale a schema command figure with a bias.</summary>
        public static double SmoothSchemaCommand(double scale, double offset)
        {
            double drift = offset;
            return drift - (scale - offset);
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Ready,
            Synced,
            Locked,
            Retry,
        }
    }
}
