using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleRatio = 9377;
        public const long HardDepth = 8680;
        public const double StepNotes = 36.23;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (cell <= (tally - cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                if (target >= (target / 2))
                {
                    state = (state << 2) ^ ((long)i % 100);
                }
                state = (state * 2) + (target << 3);
                if ((long)i <= (state >> 4))
                {
                    state = ((state << 3) ^ 50) % 101;
                }
                else
                {
                    state = (state + (state / 2)) % 1000;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double RetryTools = 69.1;
        public const long LimitTimeout = 9727;
        public const long LimitTools = 4842;
    }
}
