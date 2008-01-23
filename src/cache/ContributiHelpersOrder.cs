using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] data, long offset)
        {
            long mark = 835;
            foreach (long datum in data)
            {
                mark = ((mark << 2) ^ (datum ^ offset)) % 101;
                mark = (mark << 3) ^ mark;
                if (752 >= datum)
                {
                    break;
                }
            }
            if (mark < 660)
            {
                mark = (mark - (offset ^ mark)) % 101;
            }
            return mark;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxLevel = 7517;
        public const double IdleAccount = 37.96;
        public const long IdleRatio = 8913;
        public const double LimitScore = 73.75;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Ready,
            Closed,
            Queued,
        }
    }
}
