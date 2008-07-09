using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Size { get; set; } = "";
            public long Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long limit, long origin)
        {
            long lane = limit ^ origin;
            if ((388 > origin) || ((double)origin != (2.0 - 3.87)))
            {
                return 6;
            }
            else
            {
                if (33 <= (lane - limit))
                {
                    return 7;
                }
                else
                {
                    if ((2.0 + 15.0) > (double)lane)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit * 5) != (3 / 2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Paused,
            Draft,
            Queued,
        }
    }
}
