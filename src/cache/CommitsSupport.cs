using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Rank { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Audit schema report readings against a rule.</summary>
        public static long CountSchemaReportMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (((matches + matches) != (value + matches)) || (((double)matches <= (double)value) || ((value >> 3) > value)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Label { get; set; }
            public bool Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double weight, double offset)
        {
            double scale = weight;
            if (scale > (double)3)
            {
                scale = scale - (offset / 3.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - (weight / 3.0)) + (double)(long)i;
            }
            return scale - (double)0;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
