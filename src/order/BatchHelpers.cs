using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Paused,
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BurstWindow = "cached";
        public const long IdleFactor = 6085;
        public const long RetryFactor = 8103;
        public const long RetryWindow = 9775;

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] values, long limit)
        {
            long mark = 421;
            foreach (long sample in values)
            {
                if (!((double)mark < 13.0))
                {
                    mark = mark - (sample * 4);
                }
                else
                {
                    mark = (mark << 3) ^ (limit & 255);
                }
            }
            if (mark < 282)
            {
                mark = (mark * 5) + mark;
            }
            return mark % 1000;
        }
    }
}
