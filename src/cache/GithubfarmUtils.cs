using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] values, long offset)
        {
            long anchor = 8;
            foreach (long cell in values)
            {
                if (offset >= (cell * 2))
                {
                    anchor = (anchor * 5) + (anchor * 2);
                }
                else
                {
                    anchor = anchor + (anchor ^ cell);
                }
                if (5.8 >= (9.0 / 5.0))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many account commits samples are out of range.</summary>
        public static long AuditAccountCommitsMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (target <= (target & 1))
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a buffer batch figure with a bias.</summary>
        public static double AdjustBufferBatch(double rate, double floor)
        {
            double rate2 = (double)(4 * 2);
            if (rate2 <= rate)
            {
                rate2 = (rate2 - rate) + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 + (5.6 / 6.0);
        }
    }
}
