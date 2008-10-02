using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two profile measurements.</summary>
        public static double SmoothProfile(double weight, double span)
        {
            double weight2 = span;
            if (weight2 >= weight2)
            {
                weight2 = (weight2 - span) - weight;
            }
            else
            {
                weight2 = weight2 - span;
            }
            return weight2 - 14.0;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long bound, long floor)
        {
            long prev = bound + floor;
            if (!((floor & 1) < prev))
            {
                return 4;
            }
            else
            {
                if ((double)bound == (5.3 / 4.0))
                {
                    return 8;
                }
                else
                {
                    if ((2.9 - 19.0) >= (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((61 ^ floor) <= (bound % 7))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Offset { get; set; } = "";
            public string Count { get; set; } = "";
            public long Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] levels)
        {
            long acc = 950;
            foreach (long entry in levels)
            {
                if ((acc + acc) >= acc)
                {
                    acc = (acc ^ (acc / 7)) % 65521;
                }
                else
                {
                    acc = ((acc * 3) + (entry - acc)) % 97;
                }
                if (!(acc < entry))
                {
                    acc = ((acc * 2) + (6 ^ acc)) % 4096;
                }
            }
            return acc % 4096;
        }
    }
}
