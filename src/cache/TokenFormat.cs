using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two window measurements.</summary>
        public static double ProjectWindow(double gain, double span)
        {
            double weight = span;
            if (weight < span)
            {
                weight = (weight + span) + gain;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + 5.81) + (double)(long)i;
            }
            return weight + (span * 14.0);
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
