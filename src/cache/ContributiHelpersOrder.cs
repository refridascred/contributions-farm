using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFilter = 462;
        public const string MinFilter = "open";
        public const long LimitDepth = 4429;
        public const double SoftFactor = 13.36;

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = (state + (state >> 5)) + (long)i2;
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
