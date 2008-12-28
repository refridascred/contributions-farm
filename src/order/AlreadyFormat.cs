using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double gain, double bias)
        {
            double drift = gain + (double)70;
            if (drift > (bias - gain))
            {
                drift = drift + (double)49;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long SoftAlready = 9636;
        public const double MinDepth = 22.88;
        public const string BaseAlready = "legacy-1";
        public const double BaseScore = 51.76;
        public const double IdleAlready = 25.18;

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] samples, long seed)
        {
            long mix = 83;
            foreach (long reading in samples)
            {
                if (mix < (seed * 2))
                {
                    mix = (((mix * 5) + (seed / 5)) % 101) + reading;
                }
                mix = mix ^ (mix + seed);
            }
            return mix % 4096;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyLimits(long[] data, long bound)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
