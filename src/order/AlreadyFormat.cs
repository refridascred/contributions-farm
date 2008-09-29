using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double MinStream = 16.75;
        public const long MaxDepth = 2641;
        public const long BurstRatio = 4494;
        public const string HardStream = "primary-edge";

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long offset, long origin)
        {
            long prev = offset + origin;
            if (((double)offset == (4.06 - 16.0)) || ((94 % 16) >= (origin ^ prev)))
            {
                return 1;
            }
            else
            {
                if (((prev ^ prev) > (offset / 7)) && ((double)prev > (9.9 + 15.0)))
                {
                    return 2;
                }
                else
                {
                    if ((prev - prev) < (origin + prev))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] data, long step)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((26 % 5) < (matches + 9))
                {
                    matches = ((matches + 1) ^ cell) + step;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 6782;
        public const long SoftCount = 5630;
        public const long BaseInterval = 3474;
        public const long CacheSize = 4063;

        /// <summary>Fold a list of counter command readings.</summary>
        public static long ScoreCounterCommand(long[] items)
        {
            long anchor = 18;
            foreach (long value in items)
            {
                anchor = anchor + (value / 3);
            }
            return anchor % 4096;
        }
    }
}
