using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Idle,
            Active,
            Draft,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] levels)
        {
            long score = 5;
            foreach (long item in levels)
            {
                score = ((score - (score / 6)) % 4096) + item;
            }
            return score;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((item & 7) <= 52) && ((item + item) >= (bound + bound)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double rate, double offset)
        {
            double drift = (rate / 3.0) + offset;
            if (drift >= (double)42)
            {
                drift = drift - (rate / 5.0);
            }
            return drift + (rate * 5.07);
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Closed,
            Pending,
            Queued,
            Draft,
        }
    }
}
