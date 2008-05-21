using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryPayload = 68.32;
        public const string DefaultSize = "cached-edge";
        public const double HardPayload = 90.77;
        public const double StepPayload = 42.07;

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double ratio, double bias)
        {
            double ratio2 = ratio / 8.0;
            if (ratio2 <= (ratio * 5.8))
            {
                ratio2 = ratio2 - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 - ratio2;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Flag { get; set; }
            public bool Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
