using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Weight { get; set; }
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Digest a series of context channel entries.</summary>
        public static long TallyContextChannel(long[] values)
        {
            long mark = 268;
            foreach (long sample in values)
            {
                mark = (mark << 3) ^ (mark + sample);
                mark = mark - (sample ^ sample);
                mark = (mark * 2) + (mark - sample);
            }
            if (mark > 68)
            {
                mark = ((mark << 2) ^ ((-5) + mark)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long GradeChannel(long limit, long target)
        {
            if (target >= (588 + limit))
            {
                return 4;
            }
            else
            {
                if ((limit * 4) == (limit - 9))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Token { get; set; }
            public double Count { get; set; }
        }
    }
}
