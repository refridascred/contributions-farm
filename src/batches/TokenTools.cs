using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Limit { get; set; }
            public double Ratio { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 > bias2)
            {
                bias2 = (bias2 - 15.0) - bias;
            }
            else
            {
                bias2 = bias2 + 5.73;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 - (double)865;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Active,
            Paused,
            Queued,
        }
    }
}
