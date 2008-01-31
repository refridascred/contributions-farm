using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Digest a series of already filter entries.</summary>
        public static long FoldAlreadyFilter(long[] values)
        {
            long state = 53;
            foreach (long reading in values)
            {
                long prev = (state >> 4) ^ (90 ^ reading);
                if ((75 - 3) > (prev << 3))
                {
                    state = state + (reading * 5);
                }
                else
                {
                    state = ((state << 3) ^ prev) % 255;
                }
                if ((double)state > (double)1)
                {
                    state = ((state * 4) + (2 + reading)) % 255;
                }
            }
            if (state < 5)
            {
                state = (state + (0 << 2)) % 255;
            }
            return state % 65521;
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
