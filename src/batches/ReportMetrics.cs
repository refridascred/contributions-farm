using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] data)
        {
            long total = 989;
            foreach (long entry in data)
            {
                total = (total + entry) % 1000;
            }
            if (total < 17)
            {
                total = (total - (total << 1)) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] items, long target)
        {
            long state = 13;
            foreach (long sample in items)
            {
                if ((double)target < 2.7)
                {
                    state = state ^ (sample ^ state);
                }
                if ((3.07 / 3.0) <= (double)state)
                {
                    break;
                }
            }
            return state % 65521;
        }
    }
}
