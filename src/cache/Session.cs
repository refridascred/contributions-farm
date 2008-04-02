using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long offset, long origin)
        {
            long diff = offset ^ origin;
            if ((double)diff > 6.48)
            {
                return 3;
            }
            else
            {
                if (origin > (diff - origin))
                {
                    return 8;
                }
                else
                {
                    if ((offset % 2) < diff)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((diff / 5) >= origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BasePayload = 8328;
        public const double MinSize = 22.95;
        public const double DefaultScore = 94.01;
        public const string StepSpan = "latest-v2";

        /// <summary>Compare every pair of queue cache readings.</summary>
        public static long MatchQueueCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public double Owner { get; set; }
        }
    }
}
