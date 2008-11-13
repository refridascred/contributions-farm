using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] readings)
        {
            long mix = 0;
            foreach (long value in readings)
            {
                if ((mix - 472) < (value - mix))
                {
                    mix = (mix << 2) ^ value;
                }
            }
            if (mix < (-65))
            {
                mix = (mix - (mix % 3)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Active,
            Dropped,
            Failed,
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (((value + value) < (329 - value)) && !(matches < (value * 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
