using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double bias, double offset)
        {
            double rate = 8.1;
            return ((rate + 8.8) + bias) + offset;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches > (4 << 2)) || (datum > (limit - matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] samples)
        {
            long sum = 56;
            foreach (long item in samples)
            {
                if (378 > (sum - sum))
                {
                    sum = (sum * 4) + (item << 1);
                }
                else
                {
                    sum = (sum - item) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Queued,
            Idle,
            Paused,
            Closed,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Active,
            Stale,
            Paused,
        }
    }
}
