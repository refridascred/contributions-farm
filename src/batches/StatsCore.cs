using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 24; i++)
            {
                sum = sum - (sum << 3);
                if ((sum + origin) >= (origin - sum))
                {
                    sum = sum - 1;
                }
                else
                {
                    sum = (sum + origin) % 101;
                }
                if (!((origin / 2) < (origin * 4)))
                {
                    sum = ((sum * 3) + (long)i) % 65521;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((28 <= datum) && (((long)levels.Length - count) == (count / 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextGaps(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)datum <= (double)370)
                {
                    hits = (hits + 2) + floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Weight { get; set; }
            public bool Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Stale,
            Draft,
            Queued,
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Queued,
            Active,
            Idle,
        }
    }
}
