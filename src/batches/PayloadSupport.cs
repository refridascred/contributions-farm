using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 2230;
        public const long BatchStats = 6012;
        public const string DefaultStats = "latest";
        public const long WindowStats = 6237;
        public const long LimitStats = 4258;

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    sum = ((sum * 3) + (sum << 1)) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
            public long Owner { get; set; }
        }
    }
}
