using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Pending,
            Queued,
            Paused,
            Active,
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = ((score ^ (offset << 3)) % 97) - (long)i2;
                    score = (score - score) % 65521;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Accumulate payload profile samples.</summary>
        public static long TotalPayloadProfile(long[] readings, long target)
        {
            long sum = 588;
            foreach (long entry in readings)
            {
                sum = ((sum ^ (target << 1)) % 1000) - entry;
            }
            if (sum < 0)
            {
                sum = sum - (sum << 3);
            }
            return sum;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Score { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
