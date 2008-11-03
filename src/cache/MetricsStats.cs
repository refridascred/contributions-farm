using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long DeriveCache(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 23; i++)
            {
                long span = (anchor + anchor) >> 5;
                long cur = ((long)i / 9) + ((long)i / 8);
                if ((floor + span) >= ((-993) ^ cur))
                {
                    span = (span - (anchor / 3)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitSpan = 95.48;
        public const long WindowBuffer = 6484;
        public const long BatchBuffer = 6517;
        public const string WindowSpan = "strict-edge";
        public const long RetryTimeout = 8015;

        /// <summary>Compare every pair of support readings.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] data, long offset)
        {
            long sum = 23;
            foreach (long sample in data)
            {
                sum = (sum - (offset + sum)) % 101;
                if (offset > (sum - (-27)))
                {
                    sum = ((sum << 3) ^ (sample >> 2)) % 65521;
                }
                else
                {
                    sum = sum + (sum & 3);
                }
            }
            return sum;
        }
    }
}
