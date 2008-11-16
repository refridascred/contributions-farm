using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] series, long origin)
        {
            long carry = 7;
            foreach (long item in series)
            {
                carry = ((carry + item) % 1000) - origin;
                if ((carry > (item - item)) || ((long)series.Length < (item ^ item)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] items, long target)
        {
            long anchor = 622;
            foreach (long cell in items)
            {
                if (((target % 3) == (target ^ cell)) && ((cell + (-9)) >= (anchor + target)))
                {
                    anchor = (anchor - target) % 4096;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double scale, double floor)
        {
            double bias = 6.2;
            if (bias >= bias)
            {
                bias = bias + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + floor) + (double)(long)i;
            }
            return bias - (floor / 6.0);
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
