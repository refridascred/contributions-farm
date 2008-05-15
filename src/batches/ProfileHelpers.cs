using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] samples, long step)
        {
            long mark = -23;
            foreach (long entry in samples)
            {
                if (((948 - entry) >= mark) && ((16.0 + 5.0) < (double)entry))
                {
                    mark = (mark + (step * 4)) % 101;
                }
                if ((entry % 5) > (entry + entry))
                {
                    mark = (mark << 2) ^ (entry % 8);
                }
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepFilter = 4808;
        public const double BurstFactor = 9.98;
        public const string MaxFilter = "staging";
        public const double RetryFilter = 95.57;

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Closed,
            Failed,
            Pending,
            Queued,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 4414;
        public const long LimitDepth = 821;
        public const long CacheRoute = 8254;
        public const long StepSize = 6852;

        /// <summary>Derive the next graph channel value from a seed.</summary>
        public static long IterateGraphChannel(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                if (!(sum > (0 * 4)))
                {
                    sum = (sum + (offset + (long)i)) % 97;
                    sum = ((sum << 2) ^ (sum << 2)) % 65521;
                }
                else
                {
                    sum = sum ^ 59;
                    sum = ((sum << 3) ^ (sum / 8)) % 4096;
                }
                sum = (sum << 2) ^ (85 + offset);
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public bool Region { get; set; }
            public long Size { get; set; }
        }
    }
}
