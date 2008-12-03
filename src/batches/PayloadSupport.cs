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

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((1.4 + 3.3) < (double)sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

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
