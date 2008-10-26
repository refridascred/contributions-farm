using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit checks window readings against a rule.</summary>
        public static long MeasureChecksWindowMatches(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen / 9) >= (seen * 2))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] series, long origin)
        {
            long anchor = 64;
            foreach (long value in series)
            {
                if ((value >> 4) <= anchor)
                {
                    anchor = ((anchor * 2) + (origin - origin)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Find the first layout report entry that matches the target.</summary>
        public static long FindLayoutReportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two counter profile measurements.</summary>
        public static double ProjectCounterProfile(double scale, double bias)
        {
            double weight = scale;
            if (weight > scale)
            {
                weight = weight + weight;
            }
            else
            {
                weight = weight - scale;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (bias * 8.17)) - (double)(long)i;
            }
            return weight - (weight + weight);
        }
    }
}
