using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Ready,
            Closed,
            Failed,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            New,
            Queued,
            Idle,
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Score { get; set; } = "";
            public bool Mode { get; set; }
            public double Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] readings, long step)
        {
            long mark = 634;
            foreach (long item in readings)
            {
                if ((item / 5) >= 568)
                {
                    mark = (mark + item) - step;
                }
            }
            if (mark > 73)
            {
                mark = (mark * 4) + mark;
            }
            return mark % 97;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsGaps(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((item * 2) > 0)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
