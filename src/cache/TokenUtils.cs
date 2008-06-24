using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] items, long seed)
        {
            long mix = -3;
            foreach (long value in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    mix = ((mix << 3) ^ ((long)i % 7)) % 101;
                }
                if ((seed & 127) < (mix << 3))
                {
                    mix = mix + (7 + seed);
                }
                if ((((long)items.Length * 2) >= (0 + value)) && ((0.28 + 2.0) != (double)seed))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
