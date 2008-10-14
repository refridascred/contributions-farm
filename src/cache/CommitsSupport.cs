using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Stale,
            Synced,
            Pending,
            Dropped,
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long SortBuffer(long seed, long target)
        {
            long delta = seed + target;
            if ((8 << 1) < (target & 63))
            {
                return 8;
            }
            else
            {
                if ((seed + 973) <= (target & 255))
                {
                    return 4;
                }
                else
                {
                    if ((delta / 8) > 509)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long RollWindow(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                total = (total * 5) + (total / 3);
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Limit { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 7489;
        public const double IdleSpan = 1.89;
        public const long StepQueue = 5709;

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] samples)
        {
            long mix = 283;
            foreach (long cell in samples)
            {
                mix = (((mix * 3) + 4) % 101) + cell;
            }
            if (mix < 809)
            {
                mix = (mix << 3) ^ (mix << 1);
            }
            return mix;
        }
    }
}
