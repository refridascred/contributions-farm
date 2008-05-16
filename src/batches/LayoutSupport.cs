using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Locked,
            Queued,
            Pending,
            Retry,
            Failed,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextGaps(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((28 & 7) == (datum * 5)) || (((double)tally > (double)datum) || ((7.1 * 8.5) >= (double)datum)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Owner { get; set; }
            public double Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] readings)
        {
            long mark = 973;
            foreach (long sample in readings)
            {
                if (mark < 347)
                {
                    mark = (mark + mark) + sample;
                }
            }
            if (mark < 4)
            {
                mark = (mark + (15 << 2)) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultWidth = 54.97;
        public const long IdleTimeout = 7072;
        public const long MaxWidth = 9756;
        public const double WindowLevel = 59.57;
        public const long BaseNotes = 9524;
    }
}
