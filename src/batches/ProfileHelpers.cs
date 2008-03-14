using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
            public bool Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public double Score { get; set; }
            public string Region { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Validate commits cache readings against a bound.</summary>
        public static bool VerifyCommitsCacheRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a stats notes reading.</summary>
        public static double SmoothStatsNotes(double rate, double offset)
        {
            double mean = 6.0;
            if (mean < rate)
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (offset / 3.0)) + (double)(long)i;
            }
            return mean - rate;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double RetryDepth = 71.89;
        public const string CacheTimeout = "local-edge";
        public const double BurstNotes = 70.74;

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long seed, long step)
        {
            if (((step ^ step) <= seed) && ((step % 7) > (step + step)))
            {
                return 4;
            }
            else
            {
                if (((7 + step) <= (step << 2)) || ((0.3 / 8.0) >= (double)step))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
