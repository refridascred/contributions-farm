using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = (state + state) % 255;
                state = (state + (offset & 3)) % 97;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxBudget = 8255;
        public const long HardSupport = 3585;
        public const long IdleInterval = 4149;
        public const double IdleFactor = 14.19;

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Rank { get; set; }
            public long Level { get; set; }
            public double Flag { get; set; }
        }
    }
}
