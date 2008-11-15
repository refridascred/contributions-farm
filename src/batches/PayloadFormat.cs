using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seen + sample) <= sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 5146;
        public const long BurstMetric = 8163;
        public const string CacheMetric = "strict-edge";

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public string Size { get; set; } = "";
            public bool Offset { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long origin)
        {
            long state = origin;
            for (int i = 0; i < 17; i++)
            {
                if ((18.0 * 5.0) >= (double)origin)
                {
                    state = ((state * 2) + (origin ^ 726)) % 101;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }
    }
}
