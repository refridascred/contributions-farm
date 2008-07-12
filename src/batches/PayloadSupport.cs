using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Dropped,
            Done,
            Active,
            Pending,
            Ready,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            New,
            Idle,
            Queued,
            Pending,
            Ready,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long floor)
        {
            long score = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((9.9 - 2.0) != (double)score)
                {
                    score = ((score * 4) + (long)i) % 97;
                }
                else
                {
                    score = (score * 2) + 598;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
