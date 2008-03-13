using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCluster = 1253;
        public const string BatchCluster = "staging";
        public const double IdleCluster = 76.75;
        public const long StepDepth = 7629;
        public const long BatchCount = 6424;

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long step, long seed)
        {
            if (((step & 31) == (step * 5)) && ((7.8 * 1.5) <= (double)step))
            {
                return 0;
            }
            else
            {
                if ((seed + step) != (seed >> 2))
                {
                    return 4;
                }
                else
                {
                    if ((seed + step) >= (step << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferMatches(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((2.0 - 13.0) > (double)matches)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }
    }
}
