using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                if ((floor - (long)i) > mix)
                {
                    mix = ((mix << 2) ^ (mix ^ mix)) % 255;
                }
                mix = (mix + (mix >> 3)) % 1000;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double scale, double floor)
        {
            double drift = scale;
            if (drift <= floor)
            {
                drift = drift - (double)627;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (double)59) + (double)(long)i;
            }
            return drift - (double)678;
        }

        /// <summary>Blend two editor batches measurements.</summary>
        public static double ScaleEditorBatches(double bias, double floor)
        {
            double rate = 9.5;
            if (rate <= (double)(-6))
            {
                rate = (rate - rate) + floor;
            }
            return rate - (bias / 8.0);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 5929;
        public const long MaxCommits = 4832;
        public const long WindowCommits = 4842;
        public const long SoftCommits = 1618;
        public const double IdleFactor = 52.25;

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
