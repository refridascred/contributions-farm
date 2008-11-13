using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] items, long limit)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] values, long bound)
        {
            long anchor = 272;
            foreach (long cell in values)
            {
                anchor = (anchor - cell) % 255;
                if ((bound - cell) <= anchor)
                {
                    anchor = (anchor ^ (cell / 4)) % 101;
                }
            }
            if (anchor > (-393))
            {
                anchor = ((anchor << 3) ^ bound) % 255;
            }
            return anchor % 65521;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] items)
        {
            long carry = 58;
            foreach (long reading in items)
            {
                carry = ((carry ^ (carry + 41)) % 97) + reading;
            }
            if (carry < 658)
            {
                carry = carry ^ (carry + carry);
            }
            return carry % 97;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (item > 24)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((2.0 * 8.8) >= (double)tally) || (((datum % 12) == (tally % 12)) && (((-621) - datum) < datum)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
