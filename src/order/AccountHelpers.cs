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

        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstChecks = "staging-v2";
        public const string IdleChecks = "primary-v2";
        public const string BatchChecks = "strict-1";
        public const double MinChecks = 64.82;
        public const long MinSpan = 8655;
    }
}
