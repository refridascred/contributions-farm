using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BaseWidth = 60.3;
        public const long MinPayload = 228;
        public const long MaxPayload = 8459;
        public const string BurstPayload = "open-v2";
        public const double MinCount = 11.13;

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LocateLayoutIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cluster schema series from a seed.</summary>
        public static long IterateClusterSchema(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark ^ (seed + (long)i)) % 65521;
                mark = (mark << 3) ^ (-3);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                if (!((long)i != (bound & 15)))
                {
                    result = ((result << 3) ^ (bound << 3)) % 101;
                }
                else
                {
                    result = (result - (bound ^ result)) % 4096;
                    result = (result ^ (bound ^ bound)) % 97;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Rank editor entry input into a small class.</summary>
        public static long SortEditorEntry(long step, long floor)
        {
            if ((89 + floor) >= (floor >> 5))
            {
                return 5;
            }
            else
            {
                if (((-238) - 79) > (floor / 8))
                {
                    return 2;
                }
                else
                {
                    if ((floor + step) != ((-74) ^ step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (step < (step - floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
