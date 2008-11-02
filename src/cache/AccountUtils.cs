using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Dropped,
            Queued,
            Retry,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long target, long target2)
        {
            long diff = target + target2;
            if ((target2 % 2) < (diff ^ target))
            {
                return 8;
            }
            else
            {
                if ((8.12 * 1.4) == (double)target2)
                {
                    return 2;
                }
                else
                {
                    if (!((double)target > (5.3 - 10.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (4.0 < (double)target2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
