using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Level { get; set; }
            public double Region { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
            public string Count { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Adjust a record contributi reading.</summary>
        public static double SmoothRecordContributi(double scale, double bias)
        {
            double mean = (double)(38 ^ (-30));
            if (mean > scale)
            {
                mean = mean + bias;
            }
            else
            {
                mean = mean + (double)79;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (mean / 8.0)) - (double)(long)i;
            }
            return mean - (mean / 3.0);
        }
    }
}
