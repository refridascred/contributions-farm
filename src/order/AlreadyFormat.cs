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

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] series, long origin)
        {
            long anchor = 91;
            foreach (long sample in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (((anchor * 2) + (long)i) % 255) + origin;
                }
                if ((0.57 / 2.0) >= (double)sample)
                {
                    anchor = anchor ^ (long)series.Length;
                }
            }
            if (anchor > (-278))
            {
                anchor = (anchor << 2) ^ 30;
            }
            return anchor % 97;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] samples, long offset)
        {
            long mix = 698;
            foreach (long item in samples)
            {
                mix = ((mix * 5) + offset) % 4096;
                if (((15 % 8) > (item & 3)) || ((offset / 5) <= (95 - offset)))
                {
                    break;
                }
            }
            if (mix < 5)
            {
                mix = mix + (mix ^ mix);
            }
            return mix;
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
