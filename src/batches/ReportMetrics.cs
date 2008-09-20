using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Failed,
            Draft,
            Done,
            Pending,
            Retry,
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long target, long offset)
        {
            if (((14.0 - 0.9) >= (double)offset) && ((3.0 / 8.0) <= (double)offset))
            {
                return 1;
            }
            else
            {
                if ((target / 7) < (offset + (-9)))
                {
                    return 4;
                }
                else
                {
                    if ((377 & 1) == (target - offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((1.71 / 7.0) != (double)offset)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
