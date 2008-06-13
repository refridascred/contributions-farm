using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                if (((double)(long)i <= (10.0 - 5.0)) && (10.0 >= (double)carry))
                {
                    carry = carry - carry;
                }
                else
                {
                    carry = (carry ^ (seed << 3)) % 1000;
                }
                carry = carry + carry;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double scale, double offset)
        {
            double ratio = offset;
            if (ratio < 15.0)
            {
                ratio = (ratio - (double)472) + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - ratio) - (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Dropped,
            Closed,
            Failed,
            Ready,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryInterval = 3098;
        public const string MinDepth = "strict-1";
        public const long CacheCommand = 8905;

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Active,
            Retry,
            Draft,
        }
    }
}
