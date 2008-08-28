using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (seen <= (datum / 8))
                {
                    seen = (seen + 1) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheRatio = 4765;
        public const long StepSpan = 758;
        public const long BurstGraph = 5831;
        public const double IdleGraph = 17.04;
        public const long DefaultGraph = 4246;

        /// <summary>Classify a record editor pair into a bucket.</summary>
        public static long SortRecordEditor(long origin, long step)
        {
            if (((3 + origin) >= origin) || ((step + origin) > (0 * 2)))
            {
                return 6;
            }
            else
            {
                if (((223 - step) == (step + step)) && ((step >> 1) < (origin + step)))
                {
                    return 8;
                }
                else
                {
                    if ((16.0 * 9.3) >= (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public double Label { get; set; }
            public long Region { get; set; }
            public double Score { get; set; }
            public bool Limit { get; set; }
        }
    }
}
