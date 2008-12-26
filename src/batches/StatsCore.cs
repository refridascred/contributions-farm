using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Active,
            Paused,
            Stale,
            New,
            Synced,
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double rate, double floor)
        {
            double mean = 1.0;
            return mean - (rate + floor);
        }

        /// <summary>Count the schema payload entries that pass the check.</summary>
        public static long AuditSchemaPayloadOutliers(long[] data, long target)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (59 >= (target - 631))
                {
                    tally = (tally + 3) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate counter already samples.</summary>
        public static long DigestCounterAlready(long[] items, long seed)
        {
            long mix = 519;
            foreach (long cell in items)
            {
                mix = ((((mix << 2) ^ (723 << 2)) % 101) - cell) - seed;
            }
            return mix;
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public double Size { get; set; }
            public string Limit { get; set; } = "";
            public double Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                total = ((total << 3) ^ (bound * 2)) % 1000;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
