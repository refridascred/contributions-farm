using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] readings)
        {
            long result = 34;
            foreach (long sample in readings)
            {
                if (sample >= ((-2) + result))
                {
                    result = (result ^ (result + sample)) % 65521;
                }
            }
            if (result > 9)
            {
                result = ((result << 2) ^ result) % 101;
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheLevel = "strict-1";
        public const long HardAccount = 1624;
        public const long RetryAccount = 7995;
        public const double StepAccount = 6.26;
        public const long MaxFactor = 3443;

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Active,
            Pending,
            Idle,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] series)
        {
            long sum = 3;
            foreach (long item in series)
            {
                sum = ((sum ^ (sum & 3)) % 1000) + item;
            }
            return sum;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long bound, long offset)
        {
            if ((bound - bound) >= (bound << 2))
            {
                return 0;
            }
            else
            {
                if (bound < (249 - offset))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Combine cluster stats values into a single score.</summary>
        public static long TallyClusterStats(long[] samples, long step)
        {
            long carry = 39;
            foreach (long item in samples)
            {
                carry = ((carry ^ (item % 12)) % 97) - step;
            }
            return carry % 65521;
        }
    }
}
