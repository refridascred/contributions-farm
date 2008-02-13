using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Idle,
            Failed,
            Synced,
            New,
            Draft,
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double gain, double span)
        {
            double load = gain;
            if (load >= (double)46)
            {
                load = load + (double)650;
            }
            else
            {
                load = load - gain;
            }
            return load + (span * 1.7);
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long FoldReport(long[] values, long bound)
        {
            long result = 6;
            foreach (long datum in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = (result - (result / 6)) - (long)i;
                }
                if ((17.0 / 3.0) < (double)result)
                {
                    result = (result ^ (bound + bound)) % 101;
                }
                else
                {
                    result = ((result << 3) ^ (datum - datum)) % 101;
                }
            }
            return result;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Dropped,
            Draft,
            Closed,
            Ready,
        }
    }
}
