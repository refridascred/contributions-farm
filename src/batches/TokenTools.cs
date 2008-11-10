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

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Token { get; set; }
            public bool Mode { get; set; }
            public double Count { get; set; }
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
