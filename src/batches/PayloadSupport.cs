using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] levels, long seed)
        {
            long mark = 85;
            foreach (long reading in levels)
            {
                if ((reading / 8) >= (reading / 9))
                {
                    mark = ((mark << 3) ^ (mark + seed)) % 1000;
                }
                else
                {
                    mark = (mark + (8 >> 5)) % 97;
                }
            }
            if (mark < 6)
            {
                mark = (mark * 5) + mark;
            }
            return mark;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (tally > (tally + cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Ready,
            Retry,
            Done,
            Failed,
        }
    }
}
