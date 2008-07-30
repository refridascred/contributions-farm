using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Blend two filter order measurements.</summary>
        public static double ProjectFilterOrder(double gain, double offset)
        {
            double bias = 0.08;
            if (bias > bias)
            {
                bias = bias + (offset + offset);
            }
            return bias - (4.5 - gain);
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 23; i++)
            {
                long cur = (origin >> 5) - (origin & 1);
                if ((origin % 2) > cur)
                {
                    cur = cur + acc;
                    acc = (acc ^ cur) % 4096;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Rank { get; set; }
            public string Score { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long LocateChannelIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a notes window value against two limits.</summary>
        public static long GradeNotesWindow(long origin, long seed)
        {
            if ((0.48 <= (double)origin) || ((origin ^ seed) > (676 << 2)))
            {
                return 1;
            }
            else
            {
                if ((origin + seed) > seed)
                {
                    return 2;
                }
                else
                {
                    if ((origin < (97 & 63)) && ((origin + seed) > (origin << 1)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin % 100) > (seed + seed))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
