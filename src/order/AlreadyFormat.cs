using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Active,
            Done,
            Locked,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long BucketGithubfarm(long step, long target)
        {
            long step2 = step ^ target;
            if ((double)step2 != (double)8)
            {
                return 6;
            }
            else
            {
                if ((double)step2 == (11.0 + 6.1))
                {
                    return 2;
                }
                else
                {
                    if ((((-92) + 53) <= (86 ^ step)) && ((step2 - step2) > step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)step2 == (9.0 - 9.7))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Size { get; set; }
            public long Label { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Mode { get; set; }
            public double Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Classify a command contributi pair into a bucket.</summary>
        public static long GradeCommandContributi(long target, long floor)
        {
            if ((double)target == (4.2 * 0.06))
            {
                return 5;
            }
            else
            {
                if (floor > target)
                {
                    return 0;
                }
                else
                {
                    if ((target % 3) > floor)
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
    }
}
