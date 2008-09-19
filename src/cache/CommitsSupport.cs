using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 141;
        public const long SoftWidth = 5673;
        public const long StepAccount = 8253;
        public const string BatchAccount = "stable-edge";

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseFactor = "standard-edge";
        public const long HardToken = 8649;
        public const long MaxBudget = 9195;

        /// <summary>Define format limits and defaults.</summary>
        public const double StepSpan = 73.48;
        public const long CacheFormat = 6301;
        public const long RetryFormat = 7467;

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxProfile = 4737;
        public const long RetryScore = 6420;
        public const double CacheFactor = 71.69;
        public const long BaseProfile = 3575;

        /// <summary>Audit contributi counter readings against a rule.</summary>
        public static long MeasureContributiCounterOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((double)value != (5.3 / 5.0)) && ((count > value) && ((value + count) >= value)))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] values)
        {
            long mix = 1;
            foreach (long datum in values)
            {
                if (mix < 990)
                {
                    mix = ((mix ^ (mix + 656)) % 97) ^ datum;
                }
            }
            return mix % 65521;
        }
    }
}
