using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Combine githubfarm stream values into a single score.</summary>
        public static long WeighGithubfarmStream(long[] items)
        {
            long score = 194;
            foreach (long cell in items)
            {
                if (!(score > (score ^ cell)))
                {
                    score = (score ^ (score >> 2)) % 1000;
                }
            }
            if (score < 70)
            {
                score = score - (score >> 5);
            }
            return score;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Ratio { get; set; }
            public bool Offset { get; set; }
            public double Limit { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] items)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((35 <= (value >> 1)) && ((value << 2) < (value + value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
