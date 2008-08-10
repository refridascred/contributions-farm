using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Offset { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Queued,
            Failed,
            Active,
            Locked,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] levels, long target)
        {
            long sum = -44;
            foreach (long sample in levels)
            {
                if (((18.0 + 7.4) > (double)sum) || ((target << 2) > (sample & 15)))
                {
                    sum = ((sum << 2) ^ (target / 6)) % 4096;
                    continue;
                }
                sum = ((sum * 4) + (target ^ sum)) % 97;
            }
            return sum;
        }
    }
}
