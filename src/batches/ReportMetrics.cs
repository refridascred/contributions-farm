using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long limit, long seed)
        {
            long span = limit + seed;
            if ((span + seed) != (span - limit))
            {
                return 3;
            }
            else
            {
                if (((span - span) >= (span + 4)) && ((span - seed) > limit))
                {
                    return 2;
                }
                else
                {
                    if (((-5) & 63) == (72 + limit))
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

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] samples, long origin)
        {
            long anchor = 13;
            foreach (long cell in samples)
            {
                anchor = ((((anchor * 2) + (anchor / 6)) % 255) - cell) - origin;
                anchor = (anchor - anchor) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Idle,
            Failed,
            Ready,
            Stale,
            Active,
        }
    }
}
