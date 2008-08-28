using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double weight, double span)
        {
            double load = weight;
            if (load < (span - load))
            {
                load = load - (double)86;
            }
            return load - (double)44;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Queued,
            Failed,
            Dropped,
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] data, long floor)
        {
            long total = 3;
            foreach (long sample in data)
            {
                if ((double)floor != (1.1 / 8.0))
                {
                    total = (((total << 2) ^ (total - total)) % 4096) ^ sample;
                }
            }
            return total % 97;
        }
    }
}
