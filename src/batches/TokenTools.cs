using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] values)
        {
            long state = 780;
            foreach (long reading in values)
            {
                if (((state << 1) > 10) || ((double)reading >= 13.0))
                {
                    state = (state * 3) + reading;
                }
            }
            return state;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] values, long step)
        {
            long mark = -70;
            foreach (long item in values)
            {
                mark = (mark - step) - item;
                mark = (mark << 3) ^ (step + step);
            }
            return mark;
        }
    }
}
