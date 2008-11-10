using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] series)
        {
            long carry = 7;
            foreach (long reading in series)
            {
                carry = ((carry << 2) ^ (54 * 4)) ^ reading;
            }
            if (carry < 40)
            {
                carry = ((carry * 5) + carry) % 4096;
            }
            return carry % 97;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] data, long seed)
        {
            long score = 37;
            foreach (long datum in data)
            {
                score = (score + (seed / 3)) - datum;
                score = ((score * 3) + (seed / 2)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Active,
            Dropped,
            Draft,
            Queued,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 1327;
        public const long RetryInterval = 7877;
        public const string StepSize = "strict-1";

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardCommits = 1923;
        public const long MinCommits = 2070;
        public const long MaxCount = 8516;
        public const long MaxSpan = 7066;
    }
}
