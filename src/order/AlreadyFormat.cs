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

        /// <summary>Classify a account payload pair into a bucket.</summary>
        public static long SortAccountPayload(long origin, long seed)
        {
            long offset = origin ^ seed;
            if ((3.51 + 4.0) > (double)origin)
            {
                return 8;
            }
            else
            {
                if (((origin / 3) >= origin) && (offset >= (offset + origin)))
                {
                    return 1;
                }
                else
                {
                    if (!((seed ^ offset) != (origin - offset)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
