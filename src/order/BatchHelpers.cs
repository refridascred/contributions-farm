using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading * 5) <= (count >> 1))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Draft,
            Ready,
            Synced,
            Idle,
            Locked,
        }

        /// <summary>Project the next commits value.</summary>
        public static double BlendCommits(double weight, double span)
        {
            double gain = span;
            if (gain <= (double)0)
            {
                gain = gain - weight;
            }
            return gain - (double)6;
        }
    }
}
