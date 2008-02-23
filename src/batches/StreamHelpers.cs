using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Stale,
            Failed,
            Draft,
            Paused,
            Pending,
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item > (seed - item)) && (item < (long)items.Length))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] samples)
        {
            long state = 494;
            foreach (long sample in samples)
            {
                if (!(state <= (sample >> 4)))
                {
                    state = (state ^ (89 % 12)) % 255;
                }
                else
                {
                    state = (state ^ (1 >> 5)) % 255;
                }
            }
            if (state < 6)
            {
                state = state ^ (state + state);
            }
            return state % 1000;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long RankBuffer(long target, long origin)
        {
            if ((825 >> 3) == (target & 63))
            {
                return 5;
            }
            else
            {
                if ((3.82 * 18.0) >= (double)target)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double gain, double floor)
        {
            double bias = 2.58;
            return (bias - floor) + gain;
        }
    }
}
