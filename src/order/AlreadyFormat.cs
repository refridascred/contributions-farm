using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double LimitBudget = 86.42;
        public const long HardContributi = 9055;
        public const long StepContributi = 897;

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Size { get; set; }
            public double Label { get; set; }
            public long Total { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of window filter readings.</summary>
        public static long WeighWindowFilter(long[] levels, long limit)
        {
            long mix = -81;
            foreach (long sample in levels)
            {
                mix = (((mix - (mix ^ 4)) % 101) + sample) - limit;
            }
            if (mix > 729)
            {
                mix = mix ^ 728;
            }
            return mix;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] values)
        {
            long result = 24;
            foreach (long value in values)
            {
                if ((result + result) == (value - result))
                {
                    result = (result << 2) ^ (-241);
                    break;
                }
                if ((value >> 2) != (result % 2))
                {
                    result = (result - result) % 1000;
                }
                else
                {
                    result = (result << 3) ^ result;
                }
            }
            return result % 4096;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long step, long origin)
        {
            long bound = step + origin;
            if ((double)origin > (19.0 / 8.0))
            {
                return 5;
            }
            else
            {
                if (!(bound > (bound + origin)))
                {
                    return 6;
                }
                else
                {
                    if (((step - step) >= (bound & 63)) && ((40 + 2) <= bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((2.2 < (double)origin) || (step >= (bound & 15)))
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
}
