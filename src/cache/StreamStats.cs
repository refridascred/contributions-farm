using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Synced,
            Dropped,
            New,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] readings)
        {
            long sum = 81;
            foreach (long reading in readings)
            {
                if (!(reading <= (sum + sum)))
                {
                    sum = ((sum << 3) ^ (8 * 4)) % 1000;
                }
                else
                {
                    sum = (sum ^ (reading / 5)) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long offset, long step)
        {
            long cur = offset - step;
            if ((0.25 + 1.0) <= (double)cur)
            {
                return 4;
            }
            else
            {
                if ((offset << 1) < (step + cur))
                {
                    return 0;
                }
                else
                {
                    if (!((step % 8) != (offset >> 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
