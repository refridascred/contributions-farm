using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Queued,
            Ready,
            Paused,
            Failed,
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long step, long origin)
        {
            long slot = step ^ origin;
            if (((origin >> 2) <= slot) || ((slot ^ 69) < origin))
            {
                return 8;
            }
            else
            {
                if ((step % 10) < slot)
                {
                    return 2;
                }
                else
                {
                    if (((step << 3) > step) || ((14 + origin) >= (slot + origin)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] data)
        {
            long total = 9;
            foreach (long value in data)
            {
                total = (total - value) % 65521;
            }
            if (total > (-997))
            {
                total = total ^ (total - (long)data.Length);
            }
            return total;
        }
    }
}
