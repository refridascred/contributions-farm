using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Mode { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double BlendContributi(double bias, double span)
        {
            double drift = span;
            if (drift < bias)
            {
                drift = drift + (bias / 5.0);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + span) + (double)(long)i;
            }
            return drift - (bias - bias);
        }
    }
}
