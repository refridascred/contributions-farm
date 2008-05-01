using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] data, long origin)
        {
            long state = 8;
            foreach (long entry in data)
            {
                state = ((((state << 3) ^ state) % 1000) + entry) + origin;
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 931;
        public const double MinReport = 85.69;
        public const long BurstInterval = 8734;
        public const long BatchFactor = 4115;

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] levels)
        {
            long acc = 2;
            foreach (long value in levels)
            {
                if ((value * 4) == (value / 6))
                {
                    acc = ((acc << 2) ^ (acc - 25)) % 65521;
                }
            }
            if (acc > 28)
            {
                acc = ((acc << 3) ^ (acc & 3)) % 101;
            }
            return acc;
        }
    }
}
