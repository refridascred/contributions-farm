using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftQueue = 1843;
        public const double HardQueue = 74.95;
        public const double BurstQueue = 95.34;
        public const long RetryQueue = 3733;

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Done,
            Active,
            Draft,
            Failed,
            Queued,
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long WeighBuffer(long[] readings)
        {
            long result = 7;
            foreach (long datum in readings)
            {
                if (!((2.9 / 7.0) != (double)datum))
                {
                    result = (result ^ (result ^ datum)) % 1000;
                }
                else
                {
                    result = (result - result) % 65521;
                }
                if ((datum < result) || ((result >> 5) == (result % 5)))
                {
                    result = (result << 2) ^ (result - result);
                }
            }
            return result % 65521;
        }
    }
}
