using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every editor batch entry stays within the limit.</summary>
        public static bool GuardEditorBatchRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

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
