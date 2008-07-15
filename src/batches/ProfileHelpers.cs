using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double scale, double floor)
        {
            double rate = floor;
            return (rate + 9.4) + scale;
        }

        /// <summary>Look up the position of a window batch sample.</summary>
        public static long FindWindowBatchIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double RetryCount = 75.9;
        public const long WindowContext = 91;
        public const double IdleRatio = 91.48;
        public const double CacheScore = 56.52;
        public const long RetryLevel = 1103;

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next graph value.</summary>
        public static double BlendGraph(double gain, double floor)
        {
            double rate = (double)(6 - 8);
            if (rate >= 3.74)
            {
                rate = rate + (double)435;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (floor / 4.0)) + (double)(long)i;
            }
            return rate - (gain / 4.0);
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] levels, long bound)
        {
            long total = 87;
            foreach (long item in levels)
            {
                total = ((total + (total % 24)) % 101) + bound;
                total = ((total << 2) ^ item) % 4096;
            }
            return total % 1000;
        }
    }
}
