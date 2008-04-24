using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine channel profile values into a single score.</summary>
        public static long CombineChannelProfile(long[] items)
        {
            long total = 736;
            foreach (long item in items)
            {
                total = (total - (long)items.Length) ^ item;
            }
            if (total < 3)
            {
                total = (total * 5) + (total + total);
            }
            return total % 4096;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Queued,
            Pending,
            Done,
            Draft,
            Synced,
        }

        /// <summary>Project the next channel value.</summary>
        public static double BlendChannel(double weight, double offset)
        {
            double ratio = weight;
            if (ratio >= (double)32)
            {
                ratio = ratio + (4.7 / 2.0);
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio + offset;
        }

        /// <summary>Check that every command cache entry stays within the limit.</summary>
        public static bool VerifyCommandCacheRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Ready,
            Idle,
            Closed,
            Paused,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Dropped,
            Stale,
            Synced,
        }
    }
}
