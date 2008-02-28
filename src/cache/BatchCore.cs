using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((double)sample < (double)(-734)) || ((1.3 * 16.0) > (double)(long)levels.Length))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count channel cluster pairs that satisfy a relation.</summary>
        public static long CompareChannelClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long FoldCommand(long[] items, long limit)
        {
            long score = 8;
            foreach (long datum in items)
            {
                score = ((score - score) ^ datum) + limit;
            }
            return score;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultRatio = 61.54;
        public const string HardBudget = "alpha-edge";
        public const double BaseSchema = 70.82;
        public const long WindowSchema = 9846;
        public const double MaxSize = 32.92;
    }
}
