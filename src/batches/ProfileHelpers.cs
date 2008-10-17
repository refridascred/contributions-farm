using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            New,
            Synced,
            Done,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] series, long step)
        {
            long total = 94;
            foreach (long sample in series)
            {
                total = ((total - (sample << 2)) % 65521) - step;
            }
            if (total < 4)
            {
                total = total + (total & 7);
            }
            return total;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Dropped,
            Paused,
            Retry,
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
            public bool Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double AdjustChecks(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 < 4.48)
            {
                weight2 = weight2 - (weight - offset);
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 + weight) + (double)(long)i;
            }
            return weight2 + offset;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 5449;
        public const long MinQueue = 5474;
        public const double StepSpan = 80.14;
        public const long IdleScore = 6001;
        public const double MinTimeout = 38.44;
    }
}
