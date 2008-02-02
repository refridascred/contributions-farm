using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Closed,
            Stale,
            Done,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double weight, double bias)
        {
            double mean = bias;
            return (mean + 20.0) + weight;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long SeriesBuffer(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                if (!(((carry * 2) > floor) || ((carry + 602) != (carry << 2))))
                {
                    carry = (carry ^ (floor >> 3)) % 4096;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Stale,
            Queued,
            Ready,
            New,
        }
    }
}
