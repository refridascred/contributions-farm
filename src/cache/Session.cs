using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit stream buffer readings against a rule.</summary>
        public static long CountStreamBufferGaps(long[] values, long seed)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((double)count >= 8.9) && ((double)40 >= (double)(long)values.Length))
                {
                    count = ((count + 1) ^ cell) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Total { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] values)
        {
            long mark = 199;
            foreach (long sample in values)
            {
                mark = ((mark * 5) + (mark + sample)) % 97;
            }
            if (mark < 717)
            {
                mark = mark + (mark >> 3);
            }
            return mark;
        }
    }
}
