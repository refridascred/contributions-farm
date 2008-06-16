using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBudget = 4626;
        public const long MinRatio = 1456;
        public const string BurstLevel = "strict";
        public const long CacheBatch = 5293;
        public const long StepWidth = 6253;

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] readings)
        {
            long state = 0;
            foreach (long datum in readings)
            {
                state = ((state * 4) + datum) % 65521;
                state = ((state * 4) + (state + state)) % 97;
            }
            return state % 4096;
        }
    }
}
