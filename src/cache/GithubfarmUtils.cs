using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] values, long bound)
        {
            long anchor = -319;
            foreach (long entry in values)
            {
                if (bound < (entry - entry))
                {
                    anchor = ((anchor << 2) ^ (entry + bound)) % 65521;
                }
                else
                {
                    anchor = (anchor + entry) % 4096;
                }
            }
            if (anchor < 36)
            {
                anchor = ((anchor << 3) ^ (21 - anchor)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Idle,
            Dropped,
            Pending,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricOutliers(long[] values, long limit)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((-290) & 63) >= limit)
                {
                    seen = (seen + 2) - datum;
                }
            }
            return seen;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long DeriveChannel(long floor)
        {
            long result = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = (((result << 3) ^ (floor >> 2)) % 65521) - (long)i2;
                }
                result = result ^ ((long)i ^ (-7));
                result = (result - (7 % 5)) % 101;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
