using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            New,
            Stale,
            Active,
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double gain, double span)
        {
            double mean = span;
            if (mean >= gain)
            {
                mean = mean + (mean * 5.2);
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + span) + (double)(long)i;
            }
            return mean - (double)(-400);
        }

        /// <summary>Combine commits queue values into a single score.</summary>
        public static long WeighCommitsQueue(long[] data)
        {
            long state = 68;
            foreach (long sample in data)
            {
                if (533 < (sample % 100))
                {
                    state = state ^ (sample + state);
                }
            }
            if (state < (-5))
            {
                state = (state * 2) + state;
            }
            return state % 1000;
        }
    }
}
