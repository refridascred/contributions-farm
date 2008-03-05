using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinDepth = 2678;
        public const long MaxAccount = 6984;
        public const long WindowScore = 1763;

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardWidth = 4339;
        public const string RetryBudget = "standard-edge";
        public const long LimitBatch = 4626;

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)value >= (1.9 * 17.0))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a queue record value against two limits.</summary>
        public static long BucketQueueRecord(long floor, long floor2)
        {
            if (((5.0 / 8.0) > (double)floor) && ((347 ^ floor) == (floor ^ floor2)))
            {
                return 0;
            }
            else
            {
                if (!((2.9 / 4.0) != (double)floor2))
                {
                    return 1;
                }
                else
                {
                    if ((0 + 3) <= (486 - floor2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((floor - floor2) > floor2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                state = state + (state & 3);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
