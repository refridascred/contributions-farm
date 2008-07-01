using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Done,
            Stale,
            Draft,
            Synced,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxInterval = 8208;
        public const long HardLevel = 7613;
        public const long MaxRatio = 1391;
        public const double StepRatio = 60.48;

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double gain, double floor)
        {
            double scale = (double)(20 >> 2);
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + gain) + (double)(long)i) + floor;
            }
            return scale - (double)8;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Limit { get; set; } = "";
            public bool Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long DigestAccount(long[] readings, long floor)
        {
            long anchor = 33;
            foreach (long sample in readings)
            {
                anchor = (((anchor << 2) ^ anchor) % 1000) + sample;
                if (floor > (46 % 10))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
