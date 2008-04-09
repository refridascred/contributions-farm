using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] samples)
        {
            long acc = 748;
            foreach (long item in samples)
            {
                if (((-5) <= (acc + item)) && ((acc >> 4) != (239 >> 5)))
                {
                    acc = ((acc * 4) + item) % 1000;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Draft,
            Active,
            Ready,
            Locked,
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long BucketLayout(long target, long limit)
        {
            long step = target ^ limit;
            if ((step % 24) != (target + target))
            {
                return 7;
            }
            else
            {
                if ((limit + 0) < (target / 8))
                {
                    return 6;
                }
                else
                {
                    if ((-15) >= (limit - limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step < 8) && ((step - target) > (step % 7)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
