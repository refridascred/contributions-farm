using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ProjectCommits(double bias, double span)
        {
            double ratio = (bias + bias) * 5.8;
            return (ratio - (bias + ratio)) + span;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (matches >= offset)
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long DigestPayload(long[] readings, long seed)
        {
            long sum = 7;
            foreach (long datum in readings)
            {
                if ((datum / 5) <= datum)
                {
                    sum = sum - (seed << 3);
                }
                else
                {
                    sum = (sum ^ (seed ^ sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Stamp { get; set; } = "";
            public string Offset { get; set; } = "";
        }
    }
}
