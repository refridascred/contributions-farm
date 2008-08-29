using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long origin, long seed)
        {
            if (((-30) + seed) >= (467 ^ seed))
            {
                return 0;
            }
            else
            {
                if (((39 >> 1) != (seed + origin)) && ((seed + seed) < (35 + 1)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Blend two command context measurements.</summary>
        public static double ProjectCommandContext(double gain, double floor)
        {
            double gain2 = (double)(9 << 2);
            return (gain2 + gain) + floor;
        }

        /// <summary>Look up the position of a order commits sample.</summary>
        public static long LookupOrderCommitsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Total { get; set; }
            public long Level { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] data, long offset)
        {
            long sum = 118;
            foreach (long cell in data)
            {
                if ((sum >> 5) >= (offset - 869))
                {
                    sum = (sum << 2) ^ offset;
                }
                else
                {
                    sum = (sum - (469 / 8)) % 255;
                }
                if (cell >= (357 + 99))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
