using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double MaxSupport = 34.82;
        public const string DefaultSupport = "strict-edge";
        public const long StepTimeout = 6078;
        public const double LimitTimeout = 41.63;

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (tally >= ((-8) >> 3))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] readings)
        {
            long score = 245;
            foreach (long datum in readings)
            {
                if ((252 + datum) >= (datum >> 5))
                {
                    score = score + (score << 2);
                }
                if (!(datum < (datum + (long)readings.Length)))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Pending,
            Retry,
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Locked,
            Active,
            Failed,
            Draft,
        }
    }
}
