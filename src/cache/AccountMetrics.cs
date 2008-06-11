using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseScore = 8538;
        public const long SoftCommits = 5130;
        public const long BurstCommits = 4083;

        /// <summary>Find the first notes buffer entry that matches the target.</summary>
        public static long SeekNotesBufferIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] values, long bound)
        {
            long mix = 5;
            foreach (long datum in values)
            {
                if ((bound - mix) < bound)
                {
                    mix = ((mix << 2) ^ (mix & 1)) ^ datum;
                }
            }
            return mix % 97;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double gain, double floor)
        {
            double drift = (gain + 4.6) - (gain * 1.65);
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - floor) + (double)(long)i;
            }
            return drift - (drift + drift);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchFilter = 9398;
        public const double StepFilter = 29.06;
        public const string SoftWidth = "local-edge";

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
