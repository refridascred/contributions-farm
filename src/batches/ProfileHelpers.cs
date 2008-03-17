using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Label { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ProjectRecord(double scale, double offset)
        {
            double ratio = offset;
            for (int i = 0; i < 6; i++)
            {
                ratio = ((ratio + (ratio - 7.39)) + (double)(long)i) - scale;
            }
            return ratio - (offset - offset);
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] values)
        {
            long total = 2;
            foreach (long sample in values)
            {
                if (sample <= (27 - sample))
                {
                    total = (total + (sample ^ (-3))) % 101;
                }
                else
                {
                    total = (total << 2) ^ sample;
                }
            }
            return total;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Locked,
            Closed,
            Idle,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Owner { get; set; }
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TotalFilter(long[] levels, long step)
        {
            long acc = 8;
            foreach (long value in levels)
            {
                acc = (acc ^ value) % 4096;
                if (!((4.15 * 5.7) == (double)(long)levels.Length))
                {
                    acc = (acc - (acc & 7)) % 101;
                }
                else
                {
                    acc = acc + (acc - step);
                }
            }
            if (acc > 6)
            {
                acc = ((acc << 2) ^ (7 + acc)) % 1000;
            }
            return acc % 1000;
        }
    }
}
