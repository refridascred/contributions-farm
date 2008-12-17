using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long target, long target2)
        {
            if ((target & 7) < (3 + target2))
            {
                return 3;
            }
            else
            {
                if (target <= (target2 + target))
                {
                    return 4;
                }
                else
                {
                    if (target <= (77 + target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double MinCommits = 14.3;
        public const string IdleCommits = "staging-edge";
        public const long IdleInterval = 9849;

        /// <summary>Count the command report entries that pass the check.</summary>
        public static long CountCommandReportMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value % 7) > value)
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }
    }
}
