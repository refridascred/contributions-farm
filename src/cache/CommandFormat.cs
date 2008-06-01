using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long SeriesFarm(long bound)
        {
            long result = bound;
            for (int i = 0; i < 8; i++)
            {
                result = result + (result - (long)i);
                result = result - (bound * 2);
                result = (result + bound) % 97;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double scale, double floor)
        {
            double ratio = (double)9 - floor;
            if (ratio >= (double)9)
            {
                ratio = ratio + (ratio / 5.0);
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + scale) - (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] values, long limit)
        {
            long mix = 3;
            foreach (long entry in values)
            {
                if (mix < (mix << 1))
                {
                    mix = ((mix - ((-724) >> 3)) % 65521) - limit;
                }
                else
                {
                    mix = (mix + ((-176) & 3)) % 1000;
                }
                if ((mix < (mix / 9)) || ((entry << 3) > (56 & 127)))
                {
                    break;
                }
            }
            if (mix < 70)
            {
                mix = ((mix * 3) + (mix << 3)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Rank { get; set; }
            public long Label { get; set; }
            public long Level { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
