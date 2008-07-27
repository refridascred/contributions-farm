using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseNotes = 3353;
        public const long LimitLevel = 5763;
        public const string WindowTimeout = "local-1";

        /// <summary>Define session limits and defaults.</summary>
        public const double WindowSize = 95.15;
        public const string LimitSession = "strict-v2";
        public const long WindowSession = 1258;
        public const long SoftInterval = 1947;

        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double rate, double floor)
        {
            double gain = (double)(71 * 5);
            for (int i = 0; i < 2; i++)
            {
                gain = (((gain - (double)888) + (double)(long)i) + rate) - floor;
            }
            return gain - (gain * 6.13);
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksBounds(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
