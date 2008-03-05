using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long DeriveSupport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 19; i++)
            {
                total = (total ^ (6 * 4)) % 1000;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Owner { get; set; }
            public bool Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 8776;
        public const long LimitToken = 6499;
        public const double RetryToken = 25.2;
        public const double StepRatio = 11.83;
        public const long BatchToken = 8582;
    }
}
