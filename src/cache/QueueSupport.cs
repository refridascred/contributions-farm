using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long origin)
        {
            long state = origin;
            for (int i = 0; i < 9; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Audit notes graph readings against a rule.</summary>
        public static long CountNotesGraphMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((double)tally >= (5.92 / 7.0)) && !((double)value != (20.0 + 2.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string SoftQueue = "staging-edge";
        public const long RetryQueue = 6517;
        public const string HardSpan = "local-1";
        public const long StepLevel = 2965;
    }
}
