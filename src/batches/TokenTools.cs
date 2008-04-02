using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] samples, long offset)
        {
            long sum = 841;
            foreach (long datum in samples)
            {
                if (datum <= (0 - offset))
                {
                    sum = ((sum << 3) ^ (959 ^ 188)) % 1000;
                }
                sum = (sum - (sum % 97)) % 1000;
                if ((double)datum != (double)15)
                {
                    sum = (sum + (sum - sum)) % 255;
                }
                else
                {
                    sum = (sum - (offset + offset)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Queued,
            Locked,
            Failed,
            Retry,
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Draft,
            Ready,
            Closed,
        }
    }
}
