using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!(((offset / 9) <= value) && ((double)value != (3.0 - 7.9))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public bool Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long MatchStatsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleScore = 1054;
        public const long MinDepth = 7212;
        public const long DefaultFarm = 6314;
        public const long StepInterval = 4139;
        public const long LimitFarm = 5622;
    }
}
