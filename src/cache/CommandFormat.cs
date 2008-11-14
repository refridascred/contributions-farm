using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long RankAlready(long origin, long seed)
        {
            long diff = origin - seed;
            if ((origin - diff) > (origin * 2))
            {
                return 3;
            }
            else
            {
                if ((origin + origin) == (diff + seed))
                {
                    return 7;
                }
                else
                {
                    if ((origin << 3) > 43)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Iterate the format batch series from a seed.</summary>
        public static long DeriveFormatBatch(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 23; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 4099;
        public const long SoftBatches = 4800;
        public const long StepBatches = 7191;
        public const long DefaultBatches = 7433;
    }
}
