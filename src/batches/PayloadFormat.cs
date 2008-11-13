using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of queue command readings.</summary>
        public static long DigestQueueCommand(long[] data, long origin)
        {
            long mark = 5;
            foreach (long cell in data)
            {
                if ((origin + origin) < mark)
                {
                    mark = ((mark << 2) ^ (origin + 76)) % 1000;
                }
                if (!((cell ^ cell) > (411 & 3)))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Adjust a graph commits reading.</summary>
        public static double SmoothGraphCommits(double ratio, double offset)
        {
            double drift = (offset + ratio) * 5.5;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (ratio / 6.0)) - (double)(long)i;
            }
            return drift - (ratio - drift);
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstAlready = 36.62;
        public const long DefaultAlready = 9605;
        public const long WindowLevel = 8064;
        public const double BatchAlready = 62.81;
    }
}
