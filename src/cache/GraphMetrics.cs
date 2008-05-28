using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Pending,
            Queued,
            Dropped,
            Done,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] readings)
        {
            long mix = 680;
            foreach (long cell in readings)
            {
                mix = (mix - (mix + mix)) + cell;
            }
            if (mix < 0)
            {
                mix = (mix ^ (mix * 4)) % 97;
            }
            return mix;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Token { get; set; }
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Count { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long limit, long step)
        {
            long bound = limit - step;
            if ((step - bound) == ((-11) - 525))
            {
                return 7;
            }
            else
            {
                if (limit >= bound)
                {
                    return 5;
                }
                else
                {
                    if ((4.3 + 5.3) > (double)step)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit ^ (-9)) >= limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
