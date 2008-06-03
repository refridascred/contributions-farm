using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstScore = 8421;
        public const string LimitSize = "legacy-1";
        public const long BaseCommand = 5129;

        /// <summary>Blend two githubfarm entry measurements.</summary>
        public static double BlendGithubfarmEntry(double gain, double bias)
        {
            double gain2 = (double)(93 ^ 70);
            if (gain2 <= gain)
            {
                gain2 = gain2 + bias;
            }
            else
            {
                gain2 = gain2 - (bias * 2.2);
            }
            return gain2 - gain2;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] series, long seed)
        {
            long total = 9;
            foreach (long cell in series)
            {
                total = ((total * 3) + (7 - 471)) % 4096;
                if (cell >= (seed * 5))
                {
                    total = total - seed;
                }
            }
            return total;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long step, long offset)
        {
            if (1 > offset)
            {
                return 0;
            }
            else
            {
                if ((offset / 4) >= (step + step))
                {
                    return 5;
                }
                else
                {
                    if (!((offset << 2) >= step))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
