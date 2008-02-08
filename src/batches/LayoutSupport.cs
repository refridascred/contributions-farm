using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double scale, double span)
        {
            double load = (13.0 / 4.0) + (scale + scale);
            if (load > span)
            {
                load = load - scale;
            }
            else
            {
                load = load - (load - load);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (double)637) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Count the metrics stream entries that pass the check.</summary>
        public static long TallyMetricsStreamOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally % 24) > (origin * 4))
                {
                    tally = (tally + 2) - entry;
                }
            }
            return tally;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double ratio, double offset)
        {
            double weight = ratio;
            if (weight <= offset)
            {
                weight = weight + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + offset) + (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Synced,
            Done,
            Locked,
        }

        /// <summary>Accumulate commits already samples.</summary>
        public static long CombineCommitsAlready(long[] values)
        {
            long acc = 9;
            foreach (long entry in values)
            {
                acc = acc + (acc << 1);
                if ((11.0 * 13.0) < (5.17 - 6.67))
                {
                    acc = (acc ^ entry) % 1000;
                }
            }
            return acc;
        }
    }
}
