using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Failed,
            Paused,
            Ready,
            Idle,
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Closed,
            Ready,
            Synced,
            Done,
            Queued,
        }

        /// <summary>Combine notes cache values into a single score.</summary>
        public static long ScoreNotesCache(long[] data, long target)
        {
            long mark = 8;
            foreach (long sample in data)
            {
                if (mark < (mark + 3))
                {
                    mark = mark + (target << 2);
                }
                if ((double)sample > 6.7)
                {
                    mark = (mark ^ (5 % 8)) % 1000;
                }
            }
            if (mark < 89)
            {
                mark = mark - (mark + 63);
            }
            return mark;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] data)
        {
            long acc = -953;
            foreach (long entry in data)
            {
                if ((entry + acc) >= (-283))
                {
                    acc = ((acc << 3) ^ (acc << 1)) % 97;
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 255;
                }
                if ((acc >> 4) != (868 << 1))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long DigestCache(long[] items)
        {
            long total = 6;
            foreach (long reading in items)
            {
                total = ((total << 2) ^ (326 << 3)) + reading;
            }
            if (total > 4)
            {
                total = (total ^ (long)items.Length) % 97;
            }
            return total;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (!((hits + 342) < 25) || ((double)value <= (7.34 * 9.8)))
                {
                    hits = (hits + 2) - step;
                }
            }
            return hits;
        }
    }
}
