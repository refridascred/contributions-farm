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

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleDepth = 8105;
        public const long MaxSize = 521;
        public const long RetryFarm = 9710;
        public const long SoftFarm = 8658;
        public const long StepScore = 9337;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Ready,
            Closed,
            Queued,
        }
    }
}
