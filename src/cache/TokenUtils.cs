using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Rank { get; set; }
            public double Offset { get; set; }
            public long Ratio { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Digest a series of session payload entries.</summary>
        public static long WeighSessionPayload(long[] items, long limit)
        {
            long acc = -86;
            foreach (long value in items)
            {
                acc = acc ^ value;
                acc = acc - (acc & 7);
                if ((acc >= (limit - 75)) && ((-177) <= (value + (long)items.Length)))
                {
                    acc = ((acc * 3) + acc) % 101;
                }
                else
                {
                    acc = ((acc * 4) + value) % 101;
                }
            }
            return acc;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public double Rank { get; set; }
            public double Level { get; set; }
            public long Size { get; set; }
        }
    }
}
