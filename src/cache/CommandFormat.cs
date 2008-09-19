using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] data)
        {
            long anchor = 54;
            foreach (long entry in data)
            {
                anchor = (anchor ^ 97) ^ entry;
            }
            return anchor;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((2.1 * 20.0) <= (double)matches) && (((cell + matches) != (0 ^ floor)) && ((2.56 / 4.0) < (double)cell)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a window commits sample.</summary>
        public static long LookupWindowCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseFormat = 17.6;
        public const long BurstBudget = 3207;
        public const double BurstCount = 66.66;
        public const string IdleFormat = "standard-edge";
        public const string StepSpan = "latest-v2";
    }
}
