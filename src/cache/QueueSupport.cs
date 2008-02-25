using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first commits schema entry that matches the target.</summary>
        public static long LocateCommitsSchemaIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc - (acc + step)) % 255;
                acc = (acc ^ (step + (long)i)) % 65521;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
