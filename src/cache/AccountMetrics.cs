using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 7772;
        public const long RetryToken = 8002;
        public const long SoftInterval = 1711;
        public const long IdleDepth = 7908;

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Ratio { get; set; }
            public bool Owner { get; set; }
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

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= floor) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
