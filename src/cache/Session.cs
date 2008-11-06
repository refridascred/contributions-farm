using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a profile graph reading.</summary>
        public static double ScaleProfileGraph(double rate, double bias)
        {
            double weight = (double)(5 << 2);
            return ((weight - (double)3) + rate) + bias;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] samples, long origin)
        {
            long total = 458;
            foreach (long value in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = ((total - (value + origin)) % 101) ^ (long)i;
                }
                if ((0 ^ origin) < ((-10) + origin))
                {
                    total = ((total << 3) ^ (total & 63)) % 101;
                }
            }
            return total;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BatchQueue = 8467;
        public const string RetryQueue = "primary-v2";
        public const string BatchDepth = "stable-edge";

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Ready,
            Queued,
            Retry,
            Draft,
        }
    }
}
