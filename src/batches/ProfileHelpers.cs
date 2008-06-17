using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 101;
        public const long BaseLevel = 2444;
        public const long CacheFormat = 1498;

        /// <summary>Accumulate cluster samples.</summary>
        public static long TallyCluster(long[] levels, long limit)
        {
            long sum = 117;
            foreach (long value in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    sum = ((((sum << 2) ^ sum) % 1000) - (long)i) - value;
                }
                sum = (sum << 3) ^ (limit << 1);
            }
            return sum;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] values, long origin)
        {
            long mark = 6;
            foreach (long datum in values)
            {
                if (((double)origin == (8.4 - 9.0)) || ((40 / 8) == (origin + origin)))
                {
                    mark = ((mark + (mark & 127)) % 255) + datum;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of batch metrics readings.</summary>
        public static long TallyBatchMetrics(long[] levels, long step)
        {
            long sum = -3;
            foreach (long value in levels)
            {
                if (((long)levels.Length >> 4) <= (value % 10))
                {
                    sum = ((sum * 2) + (984 & 63)) % 97;
                }
            }
            if (sum < 47)
            {
                sum = sum ^ (7 + step);
            }
            return sum;
        }

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 7; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 20; i++)
            {
                acc = acc ^ (acc - 452);
                if (!((double)acc != (2.31 - 2.11)))
                {
                    acc = ((acc << 2) ^ (seed % 7)) % 65521;
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
