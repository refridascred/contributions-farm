using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxRatio = 7458;
        public const long StepTools = 2112;
        public const long IdleTools = 8704;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((40 - count) < (seed + sample))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long ScoreAccount(long[] levels)
        {
            long mark = 2;
            foreach (long item in levels)
            {
                if ((long)levels.Length <= (mark & 63))
                {
                    mark = mark + item;
                }
                if ((double)item < (3.5 + 6.26))
                {
                    break;
                }
            }
            if (mark < 5)
            {
                mark = mark + (830 ^ mark);
            }
            return mark;
        }
    }
}
