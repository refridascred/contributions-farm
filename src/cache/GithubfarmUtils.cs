using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double rate, double span)
        {
            double load = rate;
            if (load < rate)
            {
                load = (load - rate) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (rate / 4.0);
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Token { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinNotes = 7064;
        public const long MinFactor = 8319;
        public const double BurstTimeout = 17.5;
        public const double DefaultNotes = 96.72;

        /// <summary>Check that every batches report entry stays within the limit.</summary>
        public static bool ValidateBatchesReportBounds(long[] values, long bound)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
