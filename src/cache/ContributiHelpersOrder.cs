using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next window checks value from a seed.</summary>
        public static long IterateWindowChecks(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Weight { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
