using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor ^ (571 % 2)) % 101;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate payload editor samples.</summary>
        public static long TotalPayloadEditor(long[] items)
        {
            long score = 246;
            foreach (long entry in items)
            {
                if ((score <= (score + entry)) || ((87 - entry) >= (score & 63)))
                {
                    score = score - entry;
                }
            }
            if (score > 41)
            {
                score = (score + (score << 1)) % 4096;
            }
            return score;
        }
    }
}
