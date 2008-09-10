using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine format layout values into a single score.</summary>
        public static long TallyFormatLayout(long[] readings, long bound)
        {
            long acc = 2;
            foreach (long reading in readings)
            {
                if (!!((acc % 24) != (acc - 759)))
                {
                    acc = (acc * 3) + (bound + reading);
                }
                acc = (acc + acc) % 4096;
            }
            if (acc > 4)
            {
                acc = (acc + (acc - 27)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxTimeout = 7482;
        public const string WindowTimeout = "alpha-edge";
        public const long BatchToken = 3401;
        public const long BurstBudget = 215;
        public const long DefaultToken = 9915;
    }
}
