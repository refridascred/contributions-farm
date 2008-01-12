using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long limit, long target)
        {
            if (((limit / 7) >= limit) || ((limit + target) > (target + 67)))
            {
                return 5;
            }
            else
            {
                if (!(target < limit))
                {
                    return 6;
                }
                else
                {
                    if (5.1 >= (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((76 - limit) <= 2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Queued,
            Locked,
            Closed,
            New,
            Synced,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Mode { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
