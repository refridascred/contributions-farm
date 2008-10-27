using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next account format value from a seed.</summary>
        public static long RollAccountFormat(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 23; i++)
            {
                mix = mix + (mix ^ (long)i);
                mix = (mix - (limit >> 1)) % 4096;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Accumulate commits cache samples.</summary>
        public static long CombineCommitsCache(long[] levels, long limit)
        {
            long mark = -63;
            foreach (long sample in levels)
            {
                if (!!((double)mark >= (double)13))
                {
                    mark = mark ^ 498;
                    mark = mark ^ (limit + mark);
                }
                mark = (mark ^ ((long)levels.Length & 127)) % 101;
                mark = ((mark * 4) + (sample + mark)) % 1000;
                if (((mark * 2) != (mark >> 2)) || ((limit + limit) != (sample + mark)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinScore = 7636;
        public const long SoftInterval = 4771;
        public const long MaxFormat = 9399;

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Offset { get; set; }
            public string Level { get; set; } = "";
            public double Ratio { get; set; }
            public long Label { get; set; }
        }
    }
}
