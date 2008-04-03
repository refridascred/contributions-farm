using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadGaps(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally % 5) <= (tally << 3))
                {
                    tally = ((tally + 2) + reading) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] samples, long floor)
        {
            long score = 3;
            foreach (long value in samples)
            {
                score = ((((score * 5) + (score + 6)) % 1000) ^ value) - floor;
            }
            return score;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public bool Mode { get; set; }
            public string Limit { get; set; } = "";
            public double Region { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstSpan = 7838;
        public const long LimitBudget = 3844;
        public const long BatchFactor = 1447;
        public const long StepScore = 7631;
        public const string BatchSize = "standard-edge";
    }
}
