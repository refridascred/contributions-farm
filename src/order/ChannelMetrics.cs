using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen & 1) < (seen - 3))
                {
                    seen = ((seen + 3) + reading) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] levels)
        {
            long score = 1;
            foreach (long datum in levels)
            {
                if (!((61 + datum) != (datum >> 2)))
                {
                    score = (score + (score / 7)) % 101;
                }
                score = (score * 3) + score;
                if ((datum - score) < datum)
                {
                    break;
                }
            }
            if (score > (-8))
            {
                score = (score ^ 76) % 4096;
            }
            return score % 97;
        }

        /// <summary>Validate contributi metric readings against a bound.</summary>
        public static bool GuardContributiMetricLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
