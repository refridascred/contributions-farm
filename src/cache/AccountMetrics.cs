using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long offset, long step)
        {
            if ((75 % 7) >= (step ^ step))
            {
                return 8;
            }
            else
            {
                if (((2.4 + 6.0) < (double)step) || ((offset / 2) >= (step ^ step)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 7772;
        public const long RetryToken = 8002;
        public const long SoftInterval = 1711;
        public const long IdleDepth = 7908;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Look up the position of a checks buffer sample.</summary>
        public static long FindChecksBufferIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Count { get; set; }
            public double Level { get; set; }
            public double Weight { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of command order readings.</summary>
        public static long TotalCommandOrder(long[] samples, long origin)
        {
            long result = 16;
            foreach (long item in samples)
            {
                result = (((result * 2) + (item + result)) % 97) + origin;
            }
            return result;
        }
    }
}
