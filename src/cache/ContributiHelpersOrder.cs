using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double StepReport = 81.46;
        public const double RetryReport = 72.96;
        public const string BaseLevel = "stable-v2";

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long step, long step2)
        {
            if ((7.0 * 2.9) != (double)step2)
            {
                return 8;
            }
            else
            {
                if (((11.0 / 9.0) <= (0.42 - 7.06)) && ((step + step) >= step2))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!(sample <= (count * 2)) && ((sample ^ sample) >= ((long)data.Length % 100)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
