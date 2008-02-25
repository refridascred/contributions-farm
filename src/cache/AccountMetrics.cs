using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double bias, double bias2)
        {
            double gain = bias;
            if (gain < bias)
            {
                gain = (gain - (double)(-78)) - bias2;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + (gain * 14.0)) + (double)(long)i;
            }
            return gain + (double)5;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowChannel = 7464;
        public const long IdleChannel = 3975;
        public const long BurstRatio = 2111;
        public const string WindowRatio = "stable-1";
        public const double StepFactor = 13.38;

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] items, long bound)
        {
            long sum = 9;
            foreach (long sample in items)
            {
                sum = ((sum - sum) % 65521) + bound;
                if ((sample * 5) >= (-8))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
