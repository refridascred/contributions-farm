using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long target, long step)
        {
            if ((step < (target + step)) && ((double)target != (double)step))
            {
                return 0;
            }
            else
            {
                if (((step * 5) < step) || ((target * 4) > target))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public bool Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the editor record series from a seed.</summary>
        public static long RollEditorRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 22; i++)
            {
                if (!((acc - acc) > 4))
                {
                    acc = ((acc << 2) ^ acc) % 97;
                    acc = (acc + (2 & 63)) % 101;
                    continue;
                }
                acc = (acc - 4) % 255;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Validate format window readings against a bound.</summary>
        public static bool CheckFormatWindowRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (8 < (tally % 12))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }
    }
}
