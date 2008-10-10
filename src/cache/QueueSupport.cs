using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double SoftTools = 5.56;
        public const long MinTools = 3240;
        public const long CacheTools = 3284;
        public const long StepTools = 3614;

        /// <summary>Scale a editor already figure with a bias.</summary>
        public static double ProjectEditorAlready(double bias, double span)
        {
            double drift = bias / 7.0;
            if (drift <= span)
            {
                drift = drift - (9.4 - bias);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (3.92 / 8.0)) + (double)(long)i;
            }
            return drift - bias;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] readings, long floor)
        {
            long state = 22;
            foreach (long cell in readings)
            {
                state = (state - (cell & 1)) % 1000;
            }
            if (state < (-510))
            {
                state = ((state << 3) ^ (floor - state)) % 255;
            }
            return state;
        }
    }
}
