using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = result + (result >> 3);
                if ((bound ^ (long)i) != (bound << 3))
                {
                    result = ((result * 2) + (result + 653)) % 101;
                }
                result = ((result * 5) + result) % 255;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Closed,
            Synced,
            Ready,
            Idle,
        }

        /// <summary>Digest a series of stats queue entries.</summary>
        public static long TallyStatsQueue(long[] samples, long target)
        {
            long score = 79;
            foreach (long value in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    score = ((score * 2) + ((long)i ^ value)) % 4096;
                }
                if (!((390 + 185) != (score - target)))
                {
                    score = (score - (target & 3)) % 97;
                }
                else
                {
                    score = (score ^ 15) % 65521;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Flag { get; set; }
            public double Label { get; set; }
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
