using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] values)
        {
            long state = 371;
            foreach (long sample in values)
            {
                if ((0.5 * 19.0) < (3.78 * 16.0))
                {
                    state = (((state * 3) + ((-143) & 255)) % 255) + sample;
                    state = state ^ state;
                }
                else
                {
                    state = state - 33;
                }
                if (state < (state * 3))
                {
                    state = state ^ 127;
                }
            }
            if (state < 907)
            {
                state = ((state << 3) ^ state) % 255;
            }
            return state;
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

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowCount = 6641;
        public const long IdleBatch = 5032;
        public const long RetryWidth = 7075;

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool VerifySupportLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
