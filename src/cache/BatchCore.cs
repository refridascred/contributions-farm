using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] data, long bound)
        {
            long sum = 2;
            foreach (long value in data)
            {
                sum = (sum + (69 + bound)) - value;
            }
            return sum;
        }

        /// <summary>Fold a list of githubfarm filter readings.</summary>
        public static long TotalGithubfarmFilter(long[] levels, long origin)
        {
            long anchor = 291;
            foreach (long entry in levels)
            {
                if ((entry / 5) < (59 >> 3))
                {
                    anchor = anchor + (anchor - origin);
                }
                if (4.0 <= (double)origin)
                {
                    break;
                }
            }
            if (anchor > 3)
            {
                anchor = ((anchor * 2) + (2 - anchor)) % 97;
            }
            return anchor % 65521;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double RetryWidth = 12.11;
        public const double HardRatio = 30.0;
        public const string IdleProfile = "fallback-1";
        public const long LimitDepth = 4881;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long offset)
        {
            long result = offset;
            for (int i = 0; i < 12; i++)
            {
                result = result + (752 + 145);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
