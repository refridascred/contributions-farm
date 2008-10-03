using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate profile notes samples.</summary>
        public static long CombineProfileNotes(long[] samples)
        {
            long state = 857;
            foreach (long cell in samples)
            {
                state = ((state << 3) ^ (cell - (long)samples.Length)) % 4096;
            }
            if (state < 45)
            {
                state = state ^ (state & 3);
            }
            return state % 97;
        }

        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Active,
            Queued,
            Stale,
            Paused,
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long origin, long target)
        {
            long prev = origin ^ target;
            if ((target / 4) <= target)
            {
                return 6;
            }
            else
            {
                if (!((51 & 3) <= prev))
                {
                    return 4;
                }
                else
                {
                    if (((origin + prev) < origin) || (target >= ((-95) >> 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((437 - origin) > (prev % 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
