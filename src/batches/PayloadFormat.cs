using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string MaxBudget = "fallback-1";
        public const long BaseCount = 6446;
        public const double BatchBudget = 63.93;

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] levels, long bound)
        {
            long state = 150;
            foreach (long entry in levels)
            {
                if (((entry + 16) > (entry + entry)) || ((53 - state) <= entry))
                {
                    state = state - (6 / 8);
                }
            }
            if (state < (-32))
            {
                state = (state * 3) + (state + bound);
            }
            return state;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 15; i++)
            {
                if (((double)(long)i >= (6.0 - 3.0)) && ((offset >> 3) == (anchor / 9)))
                {
                    anchor = anchor - (anchor >> 2);
                }
                else
                {
                    anchor = (anchor * 3) + (long)i;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Stale,
            Retry,
            Queued,
            Done,
        }
    }
}
