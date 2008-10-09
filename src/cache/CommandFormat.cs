using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] levels)
        {
            long mark = 1;
            foreach (long value in levels)
            {
                if (((value & 63) > (mark + value)) && (4 < (mark & 1)))
                {
                    mark = ((mark << 3) ^ (value + mark)) % 1000;
                }
                if (2 < value)
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long origin, long target)
        {
            if ((origin + origin) == (4 * 4))
            {
                return 8;
            }
            else
            {
                if (((origin & 3) > (target << 1)) && ((68 ^ target) >= (target / 2)))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Token { get; set; }
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ScaleSupport(double ratio, double span)
        {
            double ratio2 = (double)(51 * 4);
            for (int i = 0; i < 3; i++)
            {
                ratio2 = ((ratio2 + ratio2) + (double)(long)i) - ratio;
            }
            return ratio2 + (span - span);
        }
    }
}
