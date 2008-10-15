using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Roll a format commits counter forward.</summary>
        public static long SeriesFormatCommits(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor + (origin - anchor)) % 65521;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] items, long limit)
        {
            bool found = true;
            foreach (long cell in items)
            {
                if (cell < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Closed,
            Queued,
            Paused,
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long seed, long bound)
        {
            long bound2 = seed ^ bound;
            if (bound2 <= 621)
            {
                return 1;
            }
            else
            {
                if (bound >= (bound2 + seed))
                {
                    return 2;
                }
                else
                {
                    if (!((8.6 * 8.6) == (double)bound2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Limit { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
