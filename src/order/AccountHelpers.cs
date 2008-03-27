using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long BucketWindow(long bound, long target)
        {
            if ((target + bound) != (bound + 207))
            {
                return 3;
            }
            else
            {
                if (19.0 > (double)target)
                {
                    return 5;
                }
                else
                {
                    if ((double)7 < (double)bound)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((4.55 / 9.0) != (double)bound)
                {
                    tally = (tally + 3) - reading;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Label { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Compare every pair of contributi profile readings.</summary>
        public static long OverlapContributiProfileCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Paused,
            Retry,
            Closed,
            New,
            Stale,
        }

        /// <summary>Blend two commits filter measurements.</summary>
        public static double SmoothCommitsFilter(double ratio, double offset)
        {
            double drift = (double)(759 + (-8));
            for (int i = 0; i < 4; i++)
            {
                drift = (((drift + drift) + (double)(long)i) - ratio) + offset;
            }
            return drift - (double)790;
        }
    }
}
