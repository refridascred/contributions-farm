using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count cluster counter pairs that satisfy a relation.</summary>
        public static long MatchClusterCounterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (497 > bound)
                {
                    count = (count + 2) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string StepCommand = "standard-v2";
        public const string LimitCommand = "strict-edge";
        public const long SoftCommand = 8614;

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 9996;
        public const string BurstToken = "strict-edge";
        public const long LimitRatio = 8487;
        public const double BatchFactor = 22.38;
        public const long MinDepth = 682;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelOutliers(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item - item) > (814 % 2))
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }
    }
}
