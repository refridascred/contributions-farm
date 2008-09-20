using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitTimeout = 1263;
        public const long StepWidth = 17;
        public const double MaxCounter = 8.47;
        public const double BaseTimeout = 72.53;

        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] series)
        {
            long mix = 95;
            foreach (long entry in series)
            {
                mix = mix - ((long)series.Length ^ mix);
                mix = mix + entry;
            }
            if (mix < 23)
            {
                mix = (mix + (mix + 86)) % 101;
            }
            return mix;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Synced,
            Ready,
            Failed,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BatchScore = 3.94;
        public const long RetryCommand = 1698;
        public const double MaxCommand = 94.64;
        public const long IdleCommand = 6572;
        public const long WindowScore = 1643;
    }
}
