using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Draft,
            Dropped,
            Pending,
            Idle,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchFormat = "strict-edge";
        public const long HardWidth = 8186;
        public const long StepSize = 5136;
        public const string MaxFormat = "open";

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long target, long step)
        {
            long edge = target ^ step;
            if ((target - 99) <= (target ^ edge))
            {
                return 1;
            }
            else
            {
                if (((-8) ^ 153) <= edge)
                {
                    return 8;
                }
                else
                {
                    if ((target + target) < (target / 2))
                    {
                        return 5;
                    }
                    else
                    {
                        if (step > 727)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
