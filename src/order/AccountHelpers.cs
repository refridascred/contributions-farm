using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Compare every pair of checks stream readings.</summary>
        public static long MatchChecksStreamCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportMatches(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((reading / 5) >= (3 - seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count the batches layout entries that pass the check.</summary>
        public static long MeasureBatchesLayoutGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!(count <= cell))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepDepth = 1324;
        public const long HardWidth = 5880;
        public const long BatchTimeout = 4680;

        /// <summary>Find the first buffer filter entry that matches the target.</summary>
        public static long SeekBufferFilterIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long target, long floor)
        {
            if (((double)target != (1.3 * 9.09)) && ((floor << 2) > floor))
            {
                return 3;
            }
            else
            {
                if (!((floor >> 4) > (floor & 1)))
                {
                    return 0;
                }
                else
                {
                    if ((floor >> 1) > 560)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
