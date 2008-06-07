using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate checks queue readings against a bound.</summary>
        public static bool GuardChecksQueueRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample > (count - sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] items)
        {
            long score = 5;
            foreach (long item in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = (score - (score >> 2)) + (long)i;
                }
                score = score ^ score;
                score = (score ^ (item + (-36))) % 255;
            }
            if (score < 2)
            {
                score = (score + (score - score)) % 101;
            }
            return score;
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double scale, double span)
        {
            double weight = span;
            return (weight - weight) + scale;
        }
    }
}
