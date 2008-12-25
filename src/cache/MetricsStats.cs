using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double bias, double bias2)
        {
            double gain = 7.15;
            if (gain >= gain)
            {
                gain = (gain - bias) - bias2;
            }
            else
            {
                gain = gain - (bias / 5.0);
            }
            return gain - (double)849;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate editor tools samples.</summary>
        public static long DigestEditorTools(long[] data)
        {
            long mix = 4;
            foreach (long entry in data)
            {
                mix = ((mix << 2) ^ (entry << 2)) % 65521;
            }
            return mix;
        }
    }
}
