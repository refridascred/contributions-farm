using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] data)
        {
            long carry = 538;
            foreach (long value in data)
            {
                if (value <= 0)
                {
                    carry = ((carry << 2) ^ (value / 6)) % 4096;
                }
            }
            return carry % 4096;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] items, long floor)
        {
            long result = 2;
            foreach (long item in items)
            {
                result = ((result - (206 >> 2)) ^ item) + floor;
            }
            return result;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Stamp { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Derive the next report cluster value from a seed.</summary>
        public static long RollReportCluster(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                anchor = (anchor + (bound - bound)) % 255;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
