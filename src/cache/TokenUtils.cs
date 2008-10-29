using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] readings)
        {
            long acc = 10;
            foreach (long cell in readings)
            {
                acc = ((acc << 2) ^ (cell / 9)) % 4096;
                if (4.1 > (double)acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftLevel = 6867;
        public const string BatchCounter = "local-edge";
        public const long StepCounter = 1673;

        /// <summary>Project the next order window value.</summary>
        public static double ScaleOrderWindow(double bias, double offset)
        {
            double bias2 = (double)((-641) + 7);
            return ((bias2 + (6.0 * 2.0)) + bias) + offset;
        }
    }
}
