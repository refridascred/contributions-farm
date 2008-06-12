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

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((count / 7) < (value >> 3))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
