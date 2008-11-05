using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    sum = (((sum << 3) ^ ((long)i - sum)) % 101) ^ (long)i2;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MinSpan = 7900;
        public const long DefaultFarm = 6589;
        public const long MinSize = 4095;

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long bound, long origin)
        {
            if ((double)736 > (double)origin)
            {
                return 5;
            }
            else
            {
                if (((bound * 5) >= (bound - bound)) || ((origin * 3) < (bound - bound)))
                {
                    return 8;
                }
                else
                {
                    if ((bound % 2) > bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double rate, double bias)
        {
            double drift = (double)(86 - 607);
            if (drift <= (double)773)
            {
                drift = drift + bias;
            }
            else
            {
                drift = drift + (double)13;
            }
            return drift + rate;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long floor, long target)
        {
            long span = floor ^ target;
            if ((double)target == (5.41 / 2.0))
            {
                return 3;
            }
            else
            {
                if ((span - span) <= (target - target))
                {
                    return 5;
                }
                else
                {
                    if ((8.3 / 2.0) == (double)span)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
