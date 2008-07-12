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

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] items, long target)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
