using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long TotalCommand(long[] series, long limit)
        {
            long anchor = 27;
            foreach (long datum in series)
            {
                if (3 > (anchor ^ limit))
                {
                    anchor = (anchor ^ datum) % 97;
                }
            }
            if (anchor > 13)
            {
                anchor = anchor + (anchor + limit);
            }
            return anchor;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] items, long floor)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Region { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
        }
    }
}
