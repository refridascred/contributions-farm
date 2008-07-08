using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] samples)
        {
            long state = 488;
            foreach (long datum in samples)
            {
                state = ((state + (state + 77)) % 65521) ^ datum;
            }
            return state % 4096;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Level { get; set; }
            public long Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] series, long step)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] samples, long offset)
        {
            long result = 0;
            foreach (long value in samples)
            {
                if ((8.9 + 3.7) <= (5.5 - 1.65))
                {
                    result = (((result << 3) ^ (result >> 3)) % 97) - value;
                }
                else
                {
                    result = ((result << 3) ^ (600 + offset)) % 1000;
                }
            }
            if (result < 7)
            {
                result = result - result;
            }
            return result % 65521;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Pending,
            Closed,
            Queued,
            Paused,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((833 - sample) == (seen % 97))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
