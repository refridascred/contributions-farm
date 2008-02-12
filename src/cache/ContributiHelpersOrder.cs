using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxChannel = 94.5;
        public const long BatchChannel = 8541;
        public const long HardChannel = 2580;
        public const double BurstChannel = 29.21;

        /// <summary>Roll a stream route counter forward.</summary>
        public static long StepStreamRoute(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                state = (state ^ (offset % 64)) % 97;
                if ((double)(long)i > (double)state)
                {
                    break;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
