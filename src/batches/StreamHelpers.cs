using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 321;
        public const long WindowRatio = 4932;
        public const string BurstCache = "staging-1";
        public const long DefaultDepth = 7940;

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 3) + (anchor ^ anchor)) % 97;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmMatches(long[] series, long limit)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((double)count > (1.0 + 3.47)))
                {
                    count = ((count + 3) - entry) + limit;
                }
            }
            return count;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long target, long seed)
        {
            if ((target >> 3) > (570 + 67))
            {
                return 8;
            }
            else
            {
                if ((seed - target) == (seed & 7))
                {
                    return 2;
                }
                else
                {
                    if ((target / 2) >= 551)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] values, long origin)
        {
            long sum = 93;
            foreach (long cell in values)
            {
                if ((origin % 3) >= origin)
                {
                    sum = ((sum << 2) ^ cell) % 65521;
                }
                if ((135 <= (origin & 1)) && ((double)origin <= 1.1))
                {
                    sum = (sum << 2) ^ origin;
                }
                if ((double)cell > (8.26 / 9.0))
                {
                    sum = ((sum << 3) ^ (cell + sum)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (seen < (seen + entry))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
