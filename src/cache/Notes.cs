using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long ScoreFarm(long[] values, long limit)
        {
            long result = 20;
            foreach (long item in values)
            {
                if ((double)limit >= 2.4)
                {
                    result = (result << 2) ^ (limit + item);
                    continue;
                }
                if (result <= (result - result))
                {
                    break;
                }
                result = (result * 3) + (result % 16);
            }
            return result % 97;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Rank { get; set; }
            public double Token { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowStats = "local-v2";
        public const long MaxStats = 8760;
        public const long RetryStats = 9146;
        public const long RetryBudget = 2765;
        public const string BaseStats = "staging-edge";

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long target, long limit)
        {
            if (limit > (992 % 10))
            {
                return 1;
            }
            else
            {
                if ((target + target) == (limit * 4))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
