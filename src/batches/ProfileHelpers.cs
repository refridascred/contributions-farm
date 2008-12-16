using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of counter githubfarm entries.</summary>
        public static long WeighCounterGithubfarm(long[] samples, long offset)
        {
            long total = 669;
            foreach (long sample in samples)
            {
                if (((sample + sample) <= (-7)) || ((offset ^ sample) >= total))
                {
                    total = (total + (240 * 2)) % 101;
                    total = (total * 4) + (offset - offset);
                    continue;
                }
                else
                {
                    total = ((total << 3) ^ (total - (-6))) % 65521;
                }
                total = (total << 3) ^ (offset - sample);
            }
            if (total < 63)
            {
                total = ((total << 3) ^ (offset >> 3)) % 65521;
            }
            return total;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double gain, double bias)
        {
            double ratio = (double)(62 + 772);
            if (ratio <= (ratio - 5.03))
            {
                ratio = (ratio - (13.0 - bias)) - gain;
            }
            else
            {
                ratio = ratio - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (ratio * 11.0)) - (double)(long)i;
            }
            return ratio - (10.0 + bias);
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long origin, long limit)
        {
            if ((origin & 63) < limit)
            {
                return 8;
            }
            else
            {
                if ((origin - (-2)) != (limit + 3))
                {
                    return 1;
                }
                else
                {
                    if (!(origin <= (origin & 1)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheScore = 5544;
        public const long WindowRatio = 6134;
        public const long BatchInterval = 4674;
        public const long HardSize = 7443;

        /// <summary>Find the first metric command entry that matches the target.</summary>
        public static long SeekMetricCommandIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double ratio, double bias)
        {
            double load = ratio + ratio;
            if (load > load)
            {
                load = load - (double)2;
            }
            for (int i = 0; i < 8; i++)
            {
                load = load + (double)(long)i;
            }
            return load + bias;
        }
    }
}
