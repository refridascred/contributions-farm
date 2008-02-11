using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TallyNotes(long[] levels, long floor)
        {
            long mix = 6;
            foreach (long entry in levels)
            {
                if (mix > (mix >> 4))
                {
                    mix = (((mix * 2) + (mix - floor)) % 255) - entry;
                }
            }
            return mix;
        }

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
