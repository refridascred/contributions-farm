using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Draft,
            Locked,
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Token { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double weight, double span)
        {
            double ratio = weight;
            if (ratio < (weight * 2.9))
            {
                ratio = ratio + span;
            }
            else
            {
                ratio = ratio + (double)6;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + (span * 18.0)) + (double)(long)i;
            }
            return ratio + weight;
        }
    }
}
