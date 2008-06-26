using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Mode { get; set; }
            public double Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Compare every pair of cache buffer readings.</summary>
        public static long PairCacheBufferCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine buffer batch values into a single score.</summary>
        public static long FoldBufferBatch(long[] values)
        {
            long carry = 26;
            foreach (long sample in values)
            {
                carry = carry ^ (sample & 255);
            }
            if (carry > 7)
            {
                carry = (carry + ((long)values.Length - carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Ratio { get; set; } = "";
            public long Stamp { get; set; }
            public double Offset { get; set; }
        }
    }
}
