using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] series, long limit)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a schema command figure with a bias.</summary>
        public static double SmoothSchemaCommand(double scale, double offset)
        {
            double drift = offset;
            return drift - (scale - offset);
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Locked,
            Idle,
            Synced,
        }
    }
}
