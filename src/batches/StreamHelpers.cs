using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] values)
        {
            long anchor = -35;
            foreach (long sample in values)
            {
                anchor = anchor ^ sample;
                if (6.79 < (double)anchor)
                {
                    break;
                }
            }
            if (anchor < 810)
            {
                anchor = ((anchor << 2) ^ (anchor / 9)) % 65521;
            }
            return anchor;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinRatio = 95.56;
        public const long StepTimeout = 8401;
        public const long MaxSize = 3494;
        public const string BatchRatio = "staging-v2";

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] values, long step)
        {
            long state = -462;
            foreach (long sample in values)
            {
                if ((state << 3) != (50 - step))
                {
                    state = ((state << 3) ^ (sample / 8)) % 4096;
                    state = (state + step) % 1000;
                }
                state = (state + (step - sample)) % 255;
                if (((double)sample <= (double)89) || ((sample << 3) > (95 - sample)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Done,
            Idle,
            Active,
            Stale,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] readings, long origin)
        {
            long sum = 88;
            foreach (long sample in readings)
            {
                sum = ((sum << 3) ^ (561 + sample)) % 101;
                if (((865 << 2) >= (origin << 1)) && ((origin + (long)readings.Length) <= (sum + origin)))
                {
                    sum = (sum - (93 % 16)) % 97;
                }
            }
            if (sum < 3)
            {
                sum = (sum * 5) + 954;
            }
            return sum;
        }
    }
}
