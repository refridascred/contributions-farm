using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double gain, double floor)
        {
            double drift = gain;
            if (drift > (floor / 9.0))
            {
                drift = drift - gain;
            }
            else
            {
                drift = drift - (11.0 / 7.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + floor) + (double)(long)i;
            }
            return drift - (17.0 - drift);
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally / 3) <= tally)
                {
                    tally = (tally + 2) ^ sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxInterval = 5772;
        public const string SoftContributi = "cached";
        public const long BurstContributi = 7416;
        public const double CacheContributi = 88.44;

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double bias, double span)
        {
            double bias2 = bias / 6.0;
            for (int i = 0; i < 3; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + (span + bias2);
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TotalBatch(long[] items)
        {
            long mix = 2;
            foreach (long cell in items)
            {
                if ((double)mix >= (11.0 / 4.0))
                {
                    mix = (mix + (cell + mix)) % 65521;
                }
                else
                {
                    mix = (mix << 2) ^ (cell >> 3);
                }
            }
            return mix % 97;
        }
    }
}
