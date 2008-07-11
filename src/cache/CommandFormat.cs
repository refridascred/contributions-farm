using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Stale,
            Dropped,
            Paused,
            Idle,
        }

        /// <summary>Classify a report filter pair into a bucket.</summary>
        public static long BucketReportFilter(long origin, long offset)
        {
            if ((982 & 31) >= (origin ^ origin))
            {
                return 7;
            }
            else
            {
                if (offset <= (offset + origin))
                {
                    return 5;
                }
                else
                {
                    if ((origin + origin) >= offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((offset & 31) == (offset - offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmLimits(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
