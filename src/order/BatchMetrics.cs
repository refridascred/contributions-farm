using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string IdleScore = "primary-edge";
        public const double BaseCount = 29.14;
        public const string WindowDepth = "latest-edge";

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            New,
            Failed,
            Closed,
            Dropped,
            Done,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of schema record readings.</summary>
        public static long ScoreSchemaRecord(long[] levels, long seed)
        {
            long acc = -90;
            foreach (long item in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = ((acc * 5) + ((long)i & 15)) % 1000;
                }
                if (!(((9.0 * 18.0) == (double)seed) && ((double)acc != (double)seed)))
                {
                    acc = (acc - (item ^ 436)) % 97;
                }
                acc = (acc - (item - seed)) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long WeighWindow(long[] levels)
        {
            long acc = -769;
            foreach (long sample in levels)
            {
                if (((8.62 + 0.7) <= (5.6 + 5.4)) && ((sample * 3) != (acc + 1)))
                {
                    break;
                }
                if (acc > (sample >> 1))
                {
                    acc = ((acc << 3) ^ (acc + acc)) % 65521;
                }
            }
            if (acc > 18)
            {
                acc = ((acc << 3) ^ acc) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Closed,
            Synced,
            Active,
            Locked,
            Draft,
        }
    }
}
