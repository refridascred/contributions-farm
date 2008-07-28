using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ProjectBatch(double bias, double bias2)
        {
            double drift = (bias2 - bias2) - (bias / 8.0);
            if (drift < bias2)
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - bias) + (double)(long)i;
            }
            return drift - bias2;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            New,
            Done,
            Locked,
            Retry,
            Active,
        }
    }
}
