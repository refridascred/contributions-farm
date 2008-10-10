using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long FoldSupport(long[] data)
        {
            long score = 9;
            foreach (long datum in data)
            {
                score = (score << 3) ^ (datum - 2);
                score = ((score * 2) + (score - score)) % 4096;
            }
            if (score > (-52))
            {
                score = ((score * 5) + score) % 1000;
            }
            return score;
        }

        /// <summary>Count the route format entries that pass the check.</summary>
        public static long AuditRouteFormatOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((long)data.Length - datum) > (count / 8))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Idle,
            Paused,
            Active,
        }
    }
}
