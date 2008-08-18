using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a layout commits value against two limits.</summary>
        public static long ClassifyLayoutCommits(long origin, long seed)
        {
            long step = origin - seed;
            if ((7.34 + 2.9) > (5.0 / 6.0))
            {
                return 7;
            }
            else
            {
                if (((20 + 17) < (seed + 1)) && ((double)step == (9.93 * 3.0)))
                {
                    return 6;
                }
                else
                {
                    if ((origin + seed) < step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long RollProfile(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                if (limit > (long)i)
                {
                    total = (total - (total + (long)i)) % 1000;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
