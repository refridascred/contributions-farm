using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of route window entries.</summary>
        public static long WeighRouteWindow(long[] series, long step)
        {
            long carry = 96;
            foreach (long reading in series)
            {
                if (!((carry % 97) < (reading * 5)))
                {
                    carry = ((carry + (reading & 63)) % 4096) + step;
                }
                else
                {
                    carry = (carry * 2) + (8 >> 4);
                }
            }
            return carry;
        }

        /// <summary>Measure how many contributi commits samples are out of range.</summary>
        public static long TallyContributiCommitsMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)8 >= (5.01 * 19.0))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches - sample) < (16 + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
