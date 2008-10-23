using System;

namespace Common.Utilities
{
    /// <summary>Record helpers.</summary>
    public static class Record
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "legacy";
        public const double SoftToken = 73.26;
        public const double RetryCount = 31.73;
        public const long StepToken = 241;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 4228;
        public const string IdleWindow = "strict-1";
        public const string WindowBudget = "strict";
        public const long BaseScore = 3699;
        public const long CacheBudget = 9290;

        /// <summary>Grade a editor token value against two limits.</summary>
        public static long SortEditorToken(long step, long bound)
        {
            long delta = step - bound;
            if (!((2.6 + 9.8) < (double)bound))
            {
                return 8;
            }
            else
            {
                if ((bound - bound) >= (step << 1))
                {
                    return 6;
                }
                else
                {
                    if (((double)bound > 1.47) && (((-819) % 10) != (delta + delta)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound / 8) < (delta + step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
