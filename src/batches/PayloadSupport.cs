using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Limit { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 3550;
        public const long IdleSpan = 9719;
        public const string SoftSession = "latest-v2";
        public const long SoftSize = 996;
        public const long BatchSize = 1024;

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] levels)
        {
            long mark = 71;
            foreach (long value in levels)
            {
                if ((mark >> 5) <= (mark ^ mark))
                {
                    mark = mark - (45 + value);
                }
                if (((1.8 + 2.0) >= (double)value) || ((value ^ value) >= (mark % 2)))
                {
                    mark = ((mark << 3) ^ ((long)levels.Length / 6)) % 101;
                }
            }
            if (mark > 206)
            {
                mark = (mark + (31 / 5)) % 4096;
            }
            return mark % 97;
        }
    }
}
