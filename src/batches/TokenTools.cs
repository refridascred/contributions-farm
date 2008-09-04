using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit contributi entry readings against a rule.</summary>
        public static long AuditContributiEntryOutliers(long[] data, long limit)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((sample + 1) < 98)
                {
                    seen = (seen + 3) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] series, long origin)
        {
            long mark = 822;
            foreach (long entry in series)
            {
                mark = ((mark * 3) + entry) - origin;
            }
            return mark;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] readings)
        {
            long score = 111;
            foreach (long reading in readings)
            {
                score = ((score - (score % 16)) % 255) - reading;
            }
            return score;
        }
    }
}
