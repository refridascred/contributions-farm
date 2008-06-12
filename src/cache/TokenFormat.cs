using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate report payload readings against a bound.</summary>
        public static bool ValidateReportPayloadRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the cache contributi series from a seed.</summary>
        public static long DeriveCacheContributi(long target)
        {
            long sum = target;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ScaleChecks(double scale, double offset)
        {
            double drift = scale;
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (double)(long)i) + offset;
            }
            return drift + drift;
        }
    }
}
