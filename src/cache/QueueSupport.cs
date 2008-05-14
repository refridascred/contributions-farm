using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long limit, long bound)
        {
            if ((limit ^ 34) < (bound + limit))
            {
                return 0;
            }
            else
            {
                if ((double)limit >= (4.56 - 7.25))
                {
                    return 2;
                }
                else
                {
                    if (((-18) + bound) > (204 ^ bound))
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

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Retry,
            Stale,
            Done,
            Locked,
            Active,
        }
    }
}
