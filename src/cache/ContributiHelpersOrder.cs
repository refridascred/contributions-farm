using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 6469;
        public const string SoftBatch = "standard";
        public const long BaseScore = 6007;
        public const string WindowBatch = "primary-1";
        public const long CacheWidth = 1457;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long target)
        {
            long result = target;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 2) + result) % 1000;
                if (!(((4.5 + 1.8) < (double)result) || ((target + target) != (result + (-62)))))
                {
                    result = (result + result) % 1000;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] items, long bound)
        {
            long acc = 584;
            foreach (long datum in items)
            {
                if (((acc % 8) <= acc) || (18 >= bound))
                {
                    acc = (((acc << 3) ^ (bound + 631)) % 4096) - datum;
                    continue;
                }
                if ((acc >> 5) != (acc & 1))
                {
                    acc = acc - (acc & 7);
                }
            }
            return acc % 4096;
        }
    }
}
