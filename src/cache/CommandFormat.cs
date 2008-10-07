using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public double Token { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long floor, long floor2)
        {
            if (((floor2 * 2) != (floor >> 5)) || ((floor + floor) == (floor2 / 5)))
            {
                return 5;
            }
            else
            {
                if ((9.0 + 1.15) >= (double)floor2)
                {
                    return 4;
                }
                else
                {
                    if ((floor + floor2) > floor2)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor2 + floor) != (floor2 - floor))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long floor)
        {
            long result = floor;
            for (int i = 0; i < 10; i++)
            {
                result = (result - floor) % 97;
                result = result ^ (14 + (long)i);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
