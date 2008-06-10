using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Pending,
            New,
            Synced,
            Draft,
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double gain, double span)
        {
            double rate = span;
            if (rate < 4.15)
            {
                rate = (rate - (rate + rate)) - gain;
            }
            else
            {
                rate = rate + span;
            }
            return rate - span;
        }

        /// <summary>Fold a list of already cache readings.</summary>
        public static long ScoreAlreadyCache(long[] levels)
        {
            long result = 895;
            foreach (long datum in levels)
            {
                if (result > datum)
                {
                    result = (result << 3) ^ (result + result);
                }
            }
            if (result > (-78))
            {
                result = ((result * 2) + result) % 101;
            }
            return result % 1000;
        }

        /// <summary>Measure how many format account samples are out of range.</summary>
        public static long AuditFormatAccountOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((9.15 + 4.23) < (double)matches) || (((double)item <= 15.0) && ((double)item >= (1.96 + 3.0))))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }
    }
}
