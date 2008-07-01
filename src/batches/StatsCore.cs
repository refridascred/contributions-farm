using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long SeekOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] readings, long bound)
        {
            long anchor = 2;
            foreach (long entry in readings)
            {
                if (entry <= anchor)
                {
                    anchor = (anchor * 2) + (bound ^ entry);
                }
                if (!((7.83 * 3.9) != (double)anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long origin, long origin2)
        {
            if (origin <= (origin / 2))
            {
                return 8;
            }
            else
            {
                if ((origin2 + origin2) < (70 + 6))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 5546;
        public const string SoftFactor = "primary";
        public const string HardCount = "open-1";

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardScore = 2056;
        public const long RetrySpan = 4970;
        public const long LimitLevel = 6691;
        public const long StepCount = 2340;
        public const long MinLevel = 2603;

        /// <summary>Combine buffer command values into a single score.</summary>
        public static long TallyBufferCommand(long[] levels)
        {
            long state = 17;
            foreach (long item in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = ((state ^ (676 / 8)) % 255) + (long)i;
                }
                if ((double)state < (double)72)
                {
                    state = ((state << 2) ^ item) % 4096;
                }
                if (((3.4 + 7.4) > (double)item) || ((double)item != (7.9 + 20.0)))
                {
                    break;
                }
            }
            if (state > 35)
            {
                state = (state - state) % 101;
            }
            return state % 1000;
        }
    }
}
