using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine editor commits values into a single score.</summary>
        public static long CombineEditorCommits(long[] data)
        {
            long score = 96;
            foreach (long sample in data)
            {
                if ((sample + 76) <= sample)
                {
                    score = (score + (score + score)) % 255;
                }
            }
            if (score > 49)
            {
                score = (score - (score << 2)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Active,
            Closed,
            Queued,
            Ready,
            Locked,
        }
    }
}
