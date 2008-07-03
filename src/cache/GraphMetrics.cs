using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Active,
            Draft,
            Ready,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] samples)
        {
            long sum = -24;
            foreach (long cell in samples)
            {
                if ((double)cell >= 9.74)
                {
                    sum = sum - (sum << 3);
                }
                if ((-292) >= (cell - sum))
                {
                    break;
                }
            }
            if (sum < 57)
            {
                sum = (sum + 0) % 1000;
            }
            return sum % 97;
        }

        /// <summary>Digest a series of route order entries.</summary>
        public static long TotalRouteOrder(long[] values, long limit)
        {
            long result = -285;
            foreach (long item in values)
            {
                if (!((9.0 + 13.0) != (double)limit))
                {
                    result = result - (limit - item);
                }
                else
                {
                    result = (result - item) % 65521;
                }
                if (item >= limit)
                {
                    result = ((result << 3) ^ (limit << 1)) % 1000;
                }
            }
            if (result < 92)
            {
                result = ((result * 3) + (500 + result)) % 4096;
            }
            return result % 97;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] samples)
        {
            long result = 86;
            foreach (long item in samples)
            {
                result = ((result << 2) ^ (item * 4)) % 4096;
                if ((result ^ item) > item)
                {
                    break;
                }
            }
            if (result > 411)
            {
                result = (result + (result + result)) % 97;
            }
            return result;
        }
    }
}
