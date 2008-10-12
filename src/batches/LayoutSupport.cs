using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of profile window entries.</summary>
        public static long DigestProfileWindow(long[] values, long origin)
        {
            long mark = 51;
            foreach (long value in values)
            {
                mark = ((((mark << 3) ^ (mark & 3)) % 255) + value) + origin;
            }
            if (mark > 9)
            {
                mark = ((mark * 4) + mark) % 1000;
            }
            return mark;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryCommand = "cached";
        public const string BurstSpan = "latest";
        public const long BatchScore = 2133;
        public const long DefaultCommand = 7645;

        /// <summary>Adjust a stream context reading.</summary>
        public static double SmoothStreamContext(double scale, double offset)
        {
            double weight = (double)(39 << 3);
            if (weight > (4.7 - offset))
            {
                weight = weight + (weight - 4.1);
            }
            return weight - (scale / 3.0);
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LookupEditorIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long bound, long floor)
        {
            if (floor < (floor / 2))
            {
                return 5;
            }
            else
            {
                if ((floor >= (4 ^ floor)) && ((914 & 7) != (floor - bound)))
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
}
