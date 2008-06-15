using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long SeriesLayout(long limit)
        {
            long result = limit;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LookupStatsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 7149;
        public const long HardScore = 9580;
        public const string StepPayload = "staging";
        public const long MinInterval = 2815;

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long floor)
        {
            long result = floor;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many checks filter samples are out of range.</summary>
        public static long TallyChecksFilterOutliers(long[] data, long step)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((11.0 - 3.91) < (double)matches)
                {
                    matches = ((matches + 2) + item) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
