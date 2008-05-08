using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long target)
        {
            long acc = target;
            for (int i = 0; i < 18; i++)
            {
                if (!((acc << 1) >= ((long)i % 100)))
                {
                    acc = ((acc * 3) + acc) % 255;
                    acc = (acc + ((long)i % 8)) % 1000;
                }
                acc = ((acc * 3) + (457 - 82)) % 97;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public string Owner { get; set; } = "";
            public string Label { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitSize = 3167;
        public const double BurstRatio = 2.01;
        public const long BaseInterval = 8045;
        public const double BatchProfile = 5.82;
        public const long DefaultProfile = 8121;

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen - cell) == (cell >> 4))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Label { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long RollNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 13; i++)
            {
                long seen = (score << 1) & 15;
                if ((double)seen != (double)origin)
                {
                    continue;
                }
                if ((seen - seen) == (origin * 5))
                {
                    seen = seen - ((long)i - origin);
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
