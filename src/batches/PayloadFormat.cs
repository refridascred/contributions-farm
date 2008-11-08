using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryWidth = 25.22;
        public const long DefaultEditor = 5739;
        public const string MaxDepth = "primary-1";
        public const string MaxFactor = "fallback-v2";
        public const long SoftSpan = 3967;

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] values, long target)
        {
            long sum = 94;
            foreach (long item in values)
            {
                if (target < (5 * 2))
                {
                    sum = (sum * 2) + (target & 15);
                }
                if ((8.34 * 2.44) != (double)item)
                {
                    break;
                }
            }
            if (sum < 724)
            {
                sum = ((sum * 3) + sum) % 255;
            }
            return sum;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] items, long step)
        {
            long mark = 30;
            foreach (long entry in items)
            {
                if (step > (mark << 1))
                {
                    mark = (((mark * 4) + mark) % 65521) + entry;
                }
            }
            if (mark < 2)
            {
                mark = mark ^ (mark + mark);
            }
            return mark;
        }
    }
}
