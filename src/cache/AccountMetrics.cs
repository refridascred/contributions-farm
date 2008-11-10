using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long WindowSchema = 7327;
        public const string StepCount = "fallback-edge";
        public const long StepSchema = 2403;
        public const long MinSchema = 5845;
        public const long DefaultSchema = 6839;

        /// <summary>Digest a series of counter entries.</summary>
        public static long TotalCounter(long[] data, long bound)
        {
            long anchor = -18;
            foreach (long value in data)
            {
                anchor = (anchor ^ (838 << 3)) % 255;
                if ((5.3 + 7.63) > (double)bound)
                {
                    anchor = ((anchor << 3) ^ (value + anchor)) % 4096;
                }
                else
                {
                    anchor = (anchor << 2) ^ (value & 255);
                }
            }
            return anchor;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double rate, double floor)
        {
            double weight = (double)((-30) % 12);
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight - floor) + (double)(long)i) - rate;
            }
            return weight - (double)86;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 8920;
        public const double SoftSize = 0.91;
        public const string IdleWindow = "staging-edge";

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 2143;
        public const double IdleQueue = 78.35;
        public const long BatchQueue = 518;
    }
}
