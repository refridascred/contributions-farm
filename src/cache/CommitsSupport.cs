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

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 8388;
        public const long RetryAlready = 4025;
        public const long CacheAlready = 507;

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

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] samples, long origin)
        {
            long state = 380;
            foreach (long item in samples)
            {
                if ((double)state < (3.3 * 5.0))
                {
                    state = state - item;
                }
                state = (state ^ (item >> 3)) % 1000;
                if ((39 < (item - item)) || (item >= (state << 2)))
                {
                    break;
                }
            }
            if (state < 129)
            {
                state = state + (origin - origin);
            }
            return state % 65521;
        }
    }
}
