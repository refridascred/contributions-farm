using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 8342;
        public const string SoftSpan = "legacy-1";
        public const double SoftGithubfarm = 88.85;

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Queued,
            Locked,
            Ready,
            Done,
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long offset, long offset2)
        {
            if ((offset2 - offset2) <= (offset + 67))
            {
                return 6;
            }
            else
            {
                if (((double)offset != (15.0 + 7.97)) && ((double)offset >= (7.81 + 8.79)))
                {
                    return 8;
                }
                else
                {
                    if (((double)offset > 12.0) || ((offset2 & 255) >= (offset & 63)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public double Count { get; set; }
            public long Region { get; set; }
        }
    }
}
