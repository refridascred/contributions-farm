using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Queued,
            Failed,
            Active,
            Synced,
        }

        /// <summary>Roll a tools cluster counter forward.</summary>
        public static long RollToolsCluster(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!(((0.1 - 3.0) != (double)(long)i) && ((327 - seed) <= ((long)i - seed))))
                {
                    result = ((result * 4) + (seed * 2)) % 1000;
                    result = (result - (168 >> 2)) % 4096;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Mode { get; set; }
            public bool Token { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
