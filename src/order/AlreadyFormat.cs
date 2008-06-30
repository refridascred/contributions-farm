using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstInterval = 1.75;
        public const long HardDepth = 781;
        public const long CacheOrder = 7244;

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double scale, double span)
        {
            double drift = 3.48;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift - span) + (double)(long)i) - scale;
            }
            return drift + 6.0;
        }

        /// <summary>Derive the next token editor value from a seed.</summary>
        public static long StepTokenEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                acc = acc + seed;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Iterate the stats commits series from a seed.</summary>
        public static long StepStatsCommits(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 7; i++)
            {
                sum = (sum - (limit >> 3)) % 101;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
