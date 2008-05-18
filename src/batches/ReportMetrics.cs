using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Level { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Flag { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long step, long origin)
        {
            if ((double)step < (8.0 * 5.0))
            {
                return 4;
            }
            else
            {
                if ((origin << 3) > (origin + step))
                {
                    return 1;
                }
                else
                {
                    if ((double)step > 2.3)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!(origin <= step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
