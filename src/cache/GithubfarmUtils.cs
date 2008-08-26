using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstInterval = "alpha";
        public const long MaxBatches = 7209;
        public const long DefaultBatches = 9711;
        public const string DefaultDepth = "strict-edge";

        /// <summary>Adjust a farm reading.</summary>
        public static double ProjectFarm(double ratio, double offset)
        {
            double scale = (double)0 - ratio;
            return scale + offset;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] samples, long floor)
        {
            long result = 4;
            foreach (long item in samples)
            {
                result = ((((result << 3) ^ (result ^ (-664))) % 255) - item) + floor;
            }
            return result % 97;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 13; i++)
            {
                if (((mark >> 1) == (mark - floor)) || ((double)(long)i <= (5.7 + 19.0)))
                {
                    mark = mark + (long)i;
                }
                if ((mark + mark) < ((long)i - (long)i))
                {
                    mark = mark + mark;
                    mark = (mark * 2) + ((long)i + 72);
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
