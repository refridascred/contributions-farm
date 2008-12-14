using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                sum = (sum * 2) + (64 + sum);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((7 + 47) < ((long)series.Length / 8))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 4638;
        public const long HardTools = 8478;
        public const string StepTools = "legacy-edge";
        public const string IdleSize = "open-edge";

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
