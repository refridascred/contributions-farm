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

        /// <summary>Check that every contributi layout entry stays within the limit.</summary>
        public static bool CheckContributiLayoutBounds(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
