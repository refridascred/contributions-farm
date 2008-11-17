using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Queued,
            Retry,
            Stale,
            Dropped,
            New,
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long BucketCache(long origin, long bound)
        {
            long bound2 = origin + bound;
            if ((5.0 >= (double)bound2) || ((9.1 + 8.8) >= (double)bound))
            {
                return 4;
            }
            else
            {
                if ((68 ^ 2) <= (bound2 + 27))
                {
                    return 6;
                }
                else
                {
                    if ((bound2 % 7) > bound2)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                if (!((10.0 / 8.0) <= (double)floor))
                {
                    carry = ((carry * 3) + (carry - (long)i)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
