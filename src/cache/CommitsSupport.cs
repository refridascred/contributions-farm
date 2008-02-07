using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Ratio { get; set; }
            public double Region { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit graph account readings against a rule.</summary>
        public static long AuditGraphAccountGaps(long[] data, long target)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((target - 87) <= (target + tally))
                {
                    tally = (tally + 1) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)entry <= (19.0 / 3.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
