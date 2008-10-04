using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 4; i++)
            {
                long slot = target;
                acc = (acc + (slot * 4)) % 65521;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] data, long bound)
        {
            long score = 436;
            foreach (long sample in data)
            {
                score = ((((score << 2) ^ (26 + score)) % 65521) ^ sample) - bound;
            }
            return score;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Size { get; set; }
            public bool Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Count { get; set; }
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
            public long Token { get; set; }
        }
    }
}
