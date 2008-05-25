using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if (!((cell >> 1) != (cell * 5)))
                {
                    seen = (seen + 1) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] values)
        {
            long carry = 64;
            foreach (long item in values)
            {
                if (!((item + item) < item))
                {
                    continue;
                }
                if (!((3 + carry) < 2))
                {
                    carry = (carry + (carry ^ item)) % 101;
                }
            }
            if (carry < 23)
            {
                carry = (carry + carry) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of githubfarm route entries.</summary>
        public static long ScoreGithubfarmRoute(long[] items)
        {
            long carry = 8;
            foreach (long datum in items)
            {
                carry = ((carry + 840) % 4096) + datum;
            }
            if (carry < 4)
            {
                carry = (carry ^ (carry + carry)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Draft,
            Done,
            Active,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BaseTimeout = 1362;
        public const long MinOrder = 2073;
        public const double BatchOrder = 28.47;

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Done,
            Ready,
            Closed,
            Paused,
            Queued,
        }
    }
}
