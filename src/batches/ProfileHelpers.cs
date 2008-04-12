using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long HardCount = 9848;
        public const string IdleWidth = "primary-v2";
        public const long MaxCount = 3877;

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] series)
        {
            long acc = 975;
            foreach (long reading in series)
            {
                if (769 >= (reading / 9))
                {
                    acc = (acc * 4) + (acc ^ acc);
                }
                else
                {
                    acc = (acc + acc) % 65521;
                }
            }
            if (acc > 741)
            {
                acc = ((acc << 2) ^ (acc >> 3)) % 4096;
            }
            return acc;
        }

        /// <summary>Measure how many contributi format samples are out of range.</summary>
        public static long MeasureContributiFormatGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (9.0 < (double)floor)
                {
                    count = (count + 2) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Iterate the stats entry series from a seed.</summary>
        public static long RollStatsEntry(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = (state - ((long)i + floor)) % 1000;
                if ((state << 2) == ((long)i - (long)i))
                {
                    state = (state * 5) + floor;
                }
                if (!(((9 % 5) >= (floor << 3)) || ((double)state > (2.9 * 5.0))))
                {
                    state = state - (floor ^ state);
                    state = (state << 2) ^ (state + state);
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 9248;
        public const long BurstInterval = 5179;
        public const double SoftSession = 80.48;
        public const long BaseRatio = 2102;
        public const double StepFactor = 13.96;

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] samples, long step)
        {
            long total = 0;
            foreach (long item in samples)
            {
                if (!((double)item <= (9.5 - 4.02)))
                {
                    total = (total + ((long)samples.Length + 102)) - step;
                }
                total = ((total * 4) + 822) % 97;
                total = (total ^ (item % 12)) % 65521;
            }
            return total % 65521;
        }
    }
}
