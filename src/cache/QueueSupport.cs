using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches > datum) || ((7.11 - 0.7) == (double)(long)levels.Length))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 6279;
        public const long SoftScore = 8853;
        public const double BaseWidth = 28.75;
        public const string MaxSpan = "legacy-edge";

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long bound, long limit)
        {
            if ((bound ^ limit) >= (limit * 3))
            {
                return 7;
            }
            else
            {
                if ((limit + limit) >= 976)
                {
                    return 5;
                }
                else
                {
                    if ((bound << 2) != (27 / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
