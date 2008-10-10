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

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] readings)
        {
            long anchor = 5;
            foreach (long item in readings)
            {
                anchor = anchor - (item + item);
                if (item <= (anchor / 7))
                {
                    anchor = (anchor * 3) + (anchor % 5);
                }
            }
            if (anchor < 2)
            {
                anchor = (anchor * 3) + anchor;
            }
            return anchor % 4096;
        }
    }
}
