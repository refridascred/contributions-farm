using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long seed, long offset)
        {
            if ((offset - 17) <= seed)
            {
                return 5;
            }
            else
            {
                if ((double)seed > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((9.3 + 9.95) <= (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset / 3) >= (6 + seed)) && ((seed / 4) > (seed - 45)))
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

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public string Mode { get; set; } = "";
            public string Score { get; set; } = "";
            public long Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }
    }
}
