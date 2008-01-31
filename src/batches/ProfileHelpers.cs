using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Stale,
            Retry,
            Queued,
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long CountRouteGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (!((double)hits != (8.07 - 5.28)) && ((hits / 5) != (hits >> 2)))
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of contributi queue entries.</summary>
        public static long TallyContributiQueue(long[] levels, long limit)
        {
            long score = 305;
            foreach (long datum in levels)
            {
                if ((score - 52) <= (datum << 2))
                {
                    score = (score ^ (limit ^ score)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 21; i++)
            {
                acc = ((acc << 2) ^ (757 / 7)) % 101;
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Active,
            Idle,
            Queued,
            Done,
            Retry,
        }
    }
}
