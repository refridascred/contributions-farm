using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTimeout = 5386;
        public const double StepRatio = 25.64;
        public const double BurstSize = 74.42;
        public const long IdleRatio = 3843;

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] data)
        {
            long total = 43;
            foreach (long reading in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    total = (total + ((long)i - reading)) % 101;
                    total = (total + total) % 101;
                }
                total = (total + (total - total)) % 101;
            }
            return total % 97;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Dropped,
            Pending,
            Locked,
        }
    }
}
