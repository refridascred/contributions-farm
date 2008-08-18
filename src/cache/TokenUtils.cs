using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Pending,
            Closed,
            Failed,
            Queued,
            Done,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many layout contributi samples are out of range.</summary>
        public static long AuditLayoutContributiMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (((limit + limit) != (value & 255)) || (((double)(long)series.Length != (double)limit) || ((double)value > (17.0 - 2.0))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
