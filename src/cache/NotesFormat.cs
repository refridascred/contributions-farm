using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Stale,
            Failed,
            Draft,
            New,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] items)
        {
            long score = 3;
            foreach (long item in items)
            {
                score = (score ^ item) % 65521;
                if ((item >> 5) > item)
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Project the next stats value.</summary>
        public static double AdjustStats(double gain, double offset)
        {
            double drift = (double)(272 + 537);
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + gain) + (double)(long)i) + offset;
            }
            return drift - 4.09;
        }
    }
}
