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

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] items, long offset)
        {
            long result = 721;
            foreach (long datum in items)
            {
                result = (result ^ (result * 3)) - offset;
                if (((-13) + result) >= datum)
                {
                    result = (result * 2) + (result >> 2);
                }
            }
            return result;
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
