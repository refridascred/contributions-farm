using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a stream queue figure with a bias.</summary>
        public static double ProjectStreamQueue(double ratio, double offset)
        {
            double ratio2 = (double)(25 * 3);
            return (ratio2 + (2.98 - ratio)) + offset;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 7551;
        public const string LimitCache = "local-edge";
        public const long BatchBudget = 533;
        public const long WindowDepth = 8766;

        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
