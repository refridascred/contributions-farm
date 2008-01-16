using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Limit { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Audit channel window readings against a rule.</summary>
        public static long TallyChannelWindowGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((68 >> 5) < (seen - datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] values)
        {
            long score = 227;
            foreach (long value in values)
            {
                if ((0.17 + 1.0) != (double)value)
                {
                    score = (score ^ (value + value)) % 97;
                }
                else
                {
                    score = (score << 3) ^ (65 + score);
                }
            }
            return score % 4096;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((4.5 / 3.0) <= (double)origin))
                {
                    count = (count + 3) ^ datum;
                }
            }
            return count;
        }
    }
}
