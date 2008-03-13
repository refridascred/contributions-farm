using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double bias, double floor)
        {
            double bias2 = (bias / 8.0) / 8.0;
            if (bias2 > (bias2 + bias))
            {
                bias2 = bias2 - (floor + bias2);
            }
            else
            {
                bias2 = bias2 - (double)(-60);
            }
            return bias2 + 8.93;
        }

        /// <summary>Derive the next account contributi value from a seed.</summary>
        public static long SeriesAccountContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Compare every pair of githubfarm entry readings.</summary>
        public static long OverlapGithubfarmEntryCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] values, long offset)
        {
            long anchor = 6;
            foreach (long datum in values)
            {
                if ((6 < offset) && ((double)offset != (double)datum))
                {
                    anchor = (anchor << 3) ^ (offset + offset);
                }
            }
            if (anchor > 1)
            {
                anchor = (anchor * 5) + offset;
            }
            return anchor % 1000;
        }
    }
}
