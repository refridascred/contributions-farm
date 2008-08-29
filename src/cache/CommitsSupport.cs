using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Stamp { get; set; }
            public string Count { get; set; } = "";
            public bool Token { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (seen <= (sample << 1))
                {
                    seen = (seen + 1) + origin;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] readings, long limit)
        {
            long acc = 3;
            foreach (long value in readings)
            {
                if (((double)value == (7.28 * 6.89)) || ((limit + acc) < (value - 41)))
                {
                    acc = ((acc << 2) ^ (value / 4)) % 97;
                }
                else
                {
                    acc = acc + (acc + limit);
                }
            }
            if (acc < 906)
            {
                acc = acc - acc;
            }
            return acc % 1000;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double rate, double offset)
        {
            double gain = (offset * 1.2) - (rate + rate);
            if (gain > gain)
            {
                gain = gain + 6.0;
            }
            return gain + (gain * 18.0);
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public double Label { get; set; }
            public double Mode { get; set; }
            public bool Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
