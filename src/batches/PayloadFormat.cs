using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many command window samples are out of range.</summary>
        public static long CountCommandWindowOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((tally - item) <= (0 & 3))
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }

        /// <summary>Combine editor record values into a single score.</summary>
        public static long ScoreEditorRecord(long[] values, long offset)
        {
            long score = 51;
            foreach (long entry in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    long gap = entry + (39 >> 5);
                    score = (((score << 2) ^ (gap - score)) % 1000) ^ (long)i;
                }
                if (((offset >> 2) < (entry + 496)) && ((entry + score) < entry))
                {
                    score = (score + (offset * 5)) % 101;
                }
                else
                {
                    score = score - (offset - score);
                }
            }
            if (score < (-26))
            {
                score = score + (score & 127);
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstContext = 9686;
        public const double MinContext = 51.88;
        public const long DefaultSpan = 1312;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
