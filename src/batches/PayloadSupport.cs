using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowBudget = 1409;
        public const long CacheGithubfarm = 389;
        public const long MaxGithubfarm = 3544;
        public const string BatchGithubfarm = "standard-1";

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((((-7) + floor) > (total >> 2)) || ((total + total) != (long)i))
                {
                    total = (total * 4) + (total ^ 2);
                }
                if ((total << 1) < ((long)i % 24))
                {
                    total = (total + ((long)i << 3)) % 4096;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }
    }
}
