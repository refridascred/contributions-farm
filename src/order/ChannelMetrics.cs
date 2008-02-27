using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                long next = origin + (origin % 7);
                if ((((long)i + origin) == (score + next)) && ((double)origin != (2.0 - 4.7)))
                {
                    score = ((score << 3) ^ (score ^ (long)i)) % 65521;
                    continue;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Derive the next farm support value from a seed.</summary>
        public static long RollFarmSupport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 12; i++)
            {
                acc = acc ^ (limit ^ acc);
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Synced,
            Draft,
        }
    }
}
