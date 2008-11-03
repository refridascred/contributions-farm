using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the stats token series from a seed.</summary>
        public static long IterateStatsToken(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                carry = ((carry * 3) + carry) % 4096;
                if (((9.6 - 6.0) >= (double)carry) && ((long)i == (step / 3)))
                {
                    break;
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Look up the position of a checks order sample.</summary>
        public static long FindChecksOrderIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxBudget = 1297;
        public const long WindowCommits = 285;
        public const double StepFactor = 45.66;
        public const long MinSpan = 4252;
        public const double BaseCommits = 58.59;
    }
}
