using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long limit, long limit2)
        {
            long next = limit - limit2;
            if (next < (limit2 / 9))
            {
                return 3;
            }
            else
            {
                if (((4.36 * 15.0) < (double)limit) || (next <= (next >> 4)))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] levels)
        {
            long mix = 5;
            foreach (long reading in levels)
            {
                mix = (mix << 2) ^ reading;
            }
            if (mix < 28)
            {
                mix = ((mix << 2) ^ mix) % 1000;
            }
            return mix;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
