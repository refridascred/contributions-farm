using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Derive the next githubfarm profile value from a seed.</summary>
        public static long DeriveGithubfarmProfile(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 19; i++)
            {
                sum = (sum + ((long)i + 713)) % 1000;
                sum = ((sum << 2) ^ (sum + offset)) % 101;
                if ((offset + sum) == (offset + offset))
                {
                    sum = ((sum << 3) ^ (offset / 3)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Fold a list of batches stats readings.</summary>
        public static long TotalBatchesStats(long[] readings)
        {
            long acc = 95;
            foreach (long value in readings)
            {
                if ((value / 9) == (5 << 3))
                {
                    acc = (acc + acc) % 255;
                }
                if ((value % 10) == (acc + value))
                {
                    acc = ((acc * 4) + (value + 7)) % 101;
                    acc = (acc - value) % 255;
                }
                else
                {
                    acc = (acc - (value - acc)) % 1000;
                }
                acc = (acc * 3) + value;
            }
            if (acc > 1)
            {
                acc = acc - (acc + acc);
            }
            return acc;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Offset { get; set; } = "";
            public long Label { get; set; }
            public bool Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Stale,
            Ready,
            Active,
        }
    }
}
