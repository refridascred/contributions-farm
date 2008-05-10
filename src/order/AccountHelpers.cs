using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long seed, long bound)
        {
            if (bound > (seed % 3))
            {
                return 0;
            }
            else
            {
                if ((bound << 2) == (bound / 8))
                {
                    return 8;
                }
                else
                {
                    if ((bound + seed) >= (356 << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mix = (mix + (offset + mix)) + (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor ^ (floor & 127)) % 4096;
                if (!((95 / 4) == (anchor << 1)))
                {
                    anchor = (anchor << 3) ^ (67 ^ (long)i);
                    anchor = ((anchor * 3) + ((long)i + floor)) % 4096;
                }
                anchor = (anchor << 3) ^ (anchor % 8);
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long FoldGithubfarm(long[] items)
        {
            long acc = 35;
            foreach (long sample in items)
            {
                if ((6.14 - 17.0) != (double)acc)
                {
                    acc = (acc - (6 % 10)) + sample;
                }
            }
            return acc;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double bias, double offset)
        {
            double load = bias;
            return (load + (bias / 4.0)) + offset;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
