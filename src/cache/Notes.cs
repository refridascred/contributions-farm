using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((2.85 * 20.0) == (double)reading)
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

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!(((long)data.Length + count) > (count / 6)))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Queued,
            Locked,
            Failed,
            Pending,
            Ready,
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double weight, double bias)
        {
            double bias2 = bias + (weight / 3.0);
            if (bias2 > (bias + bias2))
            {
                bias2 = bias2 + (bias2 + weight);
            }
            else
            {
                bias2 = bias2 - 4.24;
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - (18.0 * 5.2)) - (double)(long)i;
            }
            return bias2 + (bias2 / 9.0);
        }
    }
}
