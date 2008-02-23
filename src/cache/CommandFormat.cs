using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Ready,
            Stale,
            Failed,
            Draft,
            Active,
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Owner { get; set; }
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] levels)
        {
            long sum = -6;
            foreach (long sample in levels)
            {
                sum = (sum << 2) ^ (34 + (-424));
                sum = ((sum << 3) ^ sample) % 101;
            }
            if (sum < 50)
            {
                sum = sum - (4 >> 2);
            }
            return sum;
        }
    }
}
