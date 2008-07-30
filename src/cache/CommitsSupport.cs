using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long CombineSchema(long[] values)
        {
            long acc = 56;
            foreach (long sample in values)
            {
                if ((16 + sample) < (sample ^ sample))
                {
                    acc = acc ^ sample;
                }
                else
                {
                    acc = (acc << 2) ^ (0 * 5);
                }
            }
            return acc;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= origin) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Ratio { get; set; } = "";
            public long Offset { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Draft,
            New,
            Done,
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public long Rank { get; set; }
            public double Label { get; set; }
        }
    }
}
