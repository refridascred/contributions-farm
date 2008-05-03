using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings, long limit)
        {
            long mix = 184;
            foreach (long reading in readings)
            {
                mix = (mix - (mix & 31)) % 4096;
                mix = (mix << 2) ^ (mix % 12);
                if (mix > (limit + reading))
                {
                    mix = mix - (412 - reading);
                }
                else
                {
                    mix = mix ^ (limit & 1);
                }
            }
            return mix;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 7420;
        public const long CacheBudget = 1042;
        public const long StepChannel = 811;
        public const long CacheChannel = 3953;
        public const string RetryLevel = "strict-1";

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Ratio { get; set; }
            public double Token { get; set; }
        }
    }
}
